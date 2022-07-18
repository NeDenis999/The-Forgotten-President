using System.Collections.Generic;
using Code.Services;
using Entitas;
using UnityEngine;

namespace Code.Systems
{
    public class HandleDebugLogMessageSystem : ReactiveSystem<DebugEntity> 
    {
        ILogService _logService;

        public HandleDebugLogMessageSystem(IContext<DebugEntity> context, ILogService logService) : base(context)
        {
            _logService = logService; 
        }

        protected override ICollector<DebugEntity> GetTrigger(IContext<DebugEntity> context)
        {
            return context.CreateCollector(DebugMatcher.DebugLog);
        }

        protected override bool Filter(DebugEntity entity)
        {
            return entity.hasDebugLog;
        }

        protected override void Execute(List<DebugEntity> entities)
        {
            foreach (var e in entities) 
            {
                _logService.LogMessage(e.debugLog.Value);
                //e.isDestroyed = true;
            }
        }
    }
}