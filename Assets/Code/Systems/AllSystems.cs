﻿namespace Code.Systems
{
    public class AllSystems : Feature
    {
        public AllSystems(Contexts contexts, Services.Services services)
        {
            Add(new ServiceRegistrationSystems(contexts, services));
            Add(new GameplaySystems(contexts));
            Add(new GameEventSystems(contexts));
        }
    }
}