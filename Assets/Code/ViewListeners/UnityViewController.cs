using System.Collections.Generic;
using System.Linq;
using Code.Entity;
using Code.Extensions;
using Code.ViewComponentRegistrators;
using Entitas;
using Entitas.VisualDebugging.Unity;
using UnityEngine;
using EntityBehaviour = Code.Behaviours.EntityBehaviour;

namespace Code.ViewListeners
{
    public class UnityViewController : MonoBehaviour, IViewController
    {
        public GameContext Game { get; private set; }
        public GameEntity Entity { get; private set; }

        public Vector2 Position { get; set; }

        public Vector2 Scale { get; set; }

        public bool Active { get; set; }
        
        private void Start()
        {
            RegisterCollisions();
            Entity.WithNewGeneralId();
        }

        public IViewController InitializeView(GameContext @in, IEntity with)
        {
            Game = @in;
            Entity = (GameEntity) with;

            Entity.AddViewController(this);

            AddDestructedListener();

            RegisterViewComponents();

            return this;
        }

        public void DestroyView()
        {
            UnregisterCollisions();
            gameObject.UnregisterListeners(Entity);
            gameObject.DestroyGameObject();
        }

        private void RegisterViewComponents()
        {
            foreach (IViewComponentRegistrator registrator in GetComponents<IViewComponentRegistrator>())
                registrator.Register(Entity);

            AddRenderer();

            InflateEntityBehaviours();

            void AddRenderer()
            {
                var spriteRenderer = GetComponent<SpriteRenderer>();
                Entity.Do(x => x.AddSpriteRenderer(spriteRenderer), when: spriteRenderer != null);
            }
        }

        private void InflateEntityBehaviours()
        {
            foreach (EntityBehaviour behaviour in FittingBehaviours())
            {
                if (behaviour.Controller == null)
                    behaviour.ViewController = this;
            }

            IEnumerable<EntityBehaviour> FittingBehaviours() =>
                GetComponentsInChildren<EntityBehaviour>()
                    .Where(x => x.gameObject == gameObject || x.ExpectsViewInParent);
        }

        private void AddDestructedListener()
        {
            var destructedListener = GetComponent<DestructedListener>();
            if (destructedListener == null)
                gameObject.AddComponent<DestructedListener>();
        }

        private void RegisterCollisions()
        {
            foreach (Collider2D collider in GetComponentsInChildren<Collider2D>(includeInactive: true))
                Game.collidingViewRegister.Value.Register(collider.GetInstanceID(), this);
        }

        private void UnregisterCollisions()
        {
            foreach (Collider2D collider in GetComponentsInChildren<Collider2D>())
                Game.collidingViewRegister.Value.Unregister(collider.GetInstanceID(), this);
        }
    }
    
    public static partial class CleanCodeExtensions
    {
        public static void UnregisterListeners(this GameObject view, IEntity with)
        {
            foreach (IEventListener listener in view.GetComponents<IEventListener>())
                listener.UnregisterListeners(with);
        }
    }
}