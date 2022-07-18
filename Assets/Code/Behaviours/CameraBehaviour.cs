using UnityEngine;

namespace Code.Behaviours
{
    public class CameraBehaviour : EntityBehaviour
    {
        [SerializeField] 
        private Transform _target;
        
        protected override void OnStart()
        {
            base.OnStart();
            Entity.isCamera = true;
            Entity.AddPosition(transform.position);
            Entity.AddTarget(_target);
        }
    }
}