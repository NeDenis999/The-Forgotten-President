using Code.Behaviours;
using Entitas;
using UnityEngine;

namespace Code.ViewListeners
{
    public class HeroMoveListeners : MonoBehaviour, IEventListener, IMovingSpeedListener
    {
        [SerializeField] 
        private HeroAnimator _animator;
        
        GameEntity _entity;
        
        public void RegisterEventListeners(IEntity entity)
        {
            _entity = (GameEntity) entity;
            _entity.AddMovingSpeedListener(this);
        }

        public void UnregisterListeners(IEntity with)
        {
            throw new System.NotImplementedException();
        }

        public void OnMovingSpeed(GameEntity entity, float value)
        {
            _animator.SetSpeed(value);
        }
    }
}