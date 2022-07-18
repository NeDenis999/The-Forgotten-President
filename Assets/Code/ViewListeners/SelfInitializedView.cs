using Code.Behaviours;
using Code.Services;

namespace Code.ViewListeners
{
    public class SelfInitializedView : EntityBehaviour
    {
        private GameEntity _entity;

        protected override void OnAwake()
        {
            base.OnAwake();
            _entity = CreateEntity.Empty();

            ViewController.InitializeView(Contexts.sharedInstance.game, _entity);
      
            gameObject.RegisterListeners(_entity);
        }
    }
}