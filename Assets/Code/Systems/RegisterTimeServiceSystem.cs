using Code.Services;
using Entitas;

namespace Code.Systems
{
    public class RegisterTimeServiceSystem : IInitializeSystem
    {
        private readonly MetaContext _metaContext;
        private readonly ITimeService _timeService;

        public RegisterTimeServiceSystem(Contexts contexts, ITimeService timeService)
        {
            _metaContext = contexts.meta;
            _timeService = timeService;
        }

        public void Initialize()
        {
            _metaContext.ReplaceTimeService(_timeService);
        }
    }
}