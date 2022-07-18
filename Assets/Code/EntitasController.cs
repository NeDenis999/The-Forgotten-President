using System;
using Code.Services;
using Code.Systems;
using UnityEngine;

namespace Code
{
    public class EntitasController : MonoBehaviour
    {
        private Entitas.Systems _systems;
        private Services.Services _services;

        private void Awake()
        {
            _services = new Services.Services
            {
                InputService = new UnityInputService(),
                LogService = new UnityDebugLogService(),
                TimeService = new UnityTimeService(),
                ViewService = new UnityViewService(),
                IdentifierService =  new GameIdentifierService(),
                CoroutineDirectorService = new UnityCoroutineDirectorService(this),
                CollidingViewRegister =  new UnityCollidingViewRegister()
            };
            
            Contexts contexts = Contexts.sharedInstance;

            _systems = new AllSystems(contexts, _services);
        }

        private void Start()
        {
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void OnApplicationQuit()
        {
            //CreateEntity
        }
    }
}