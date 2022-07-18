using Code.Services;
using UnityEngine;

namespace Code.Systems
{
    public class ServiceRegistrationSystems : Feature
    {
        public ServiceRegistrationSystems(Contexts contexts, Services.Services services) : base(nameof(ServiceRegistrationSystems))
        {
            //Add(new RegisterViewServiceSystem(contexts, services.View));
            //Add(new RegisterTimeServiceSystem(contexts, services.TimeService));
            //Add(new RegisterApplicationServiceSystem(contexts, services.Application));
            //Add(new RegisterInputServiceSystem(contexts.input, services.InputService));
            Add(new RegisterServiceSystem<ITimeService>(services.TimeService, contexts.meta.ReplaceTimeService));
            Add(new RegisterServiceSystem<IInputService>(services.InputService, contexts.input.ReplaceInputService));
            Add(new RegisterServiceSystem<IIdentifierService>(services.IdentifierService, contexts.game.ReplaceIdentifiers));
            Add(new RegisterServiceSystem<ICoroutineDirectorService>(services.CoroutineDirectorService, contexts.meta.ReplaceCoroutineDirector));
            Add(new RegisterServiceSystem<IRegisterService<IViewController>>(services.CollidingViewRegister, contexts.game.ReplaceCollidingViewRegister));
            //Add(new RegisterAiServiceSystem(contexts, services.Ai));
            //Add(new RegisterConfigurationServiceSystem(contexts, services.Config));
            //Add(new RegisterCameraServiceSystem(contexts, services.Camera));
            //Add(new RegisterPhysicsServiceSystem(contexts, services.Physics));
            //Add(new ServiceRegistrationCompleteSystem(contexts));
        }
    }
}