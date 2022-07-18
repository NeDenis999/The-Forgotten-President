using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Code.Behaviours
{
    public class GlobalLightBehaviour : EntityBehaviour
    {
        [SerializeField] 
        private Light2D _light2D;
        
        protected override void OnStart()
        {
            base.OnStart();
            Entity.isGlobalLight = true;
            Entity.AddLight(_light2D);
            Entity.AddColor(_light2D.color);
            Entity.AddColorState(0);
            Entity.AddTime(0);
        }
    }
}