using System.Collections.Generic;
using Code.Services;
using Entitas;

namespace Code.Systems
{
    public class LoadAssetSystem : ReactiveSystem<GameEntity>, IInitializeSystem 
    {
        readonly Contexts _contexts;
        private IViewService _viewService;
        
        public LoadAssetSystem(IContext<GameEntity> context) : base(context)
        {
            
        }

        public void Initialize() 
        {
            _viewService = _contexts.meta.viewService.Value;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Asset);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasAsset && !entity.hasView;
        }

        protected override void Execute(List<GameEntity> entities) 
        {
            foreach (var e in entities) 
            {
                /*var view = _viewService.LoadAsset(_contexts, e, e.asset.Value); 
                
                if (view != null) 
                    e.ReplaceView(view);*/
            }
        }
    }
}