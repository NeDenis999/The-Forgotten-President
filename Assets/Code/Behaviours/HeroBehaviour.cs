using System;
using UnityEngine;

namespace Code.Behaviours
{
    public class HeroBehaviour : EntityBehaviour
    {
        [SerializeField] 
        private Rigidbody2D _rigidbody2D;
        
        protected override void OnStart()
        {
            base.OnStart();
            Entity.isHero = true;
            Entity.AddPosition(transform.position);
            Entity.AddRigidbody(_rigidbody2D);
            Entity.AddDirection(new Vector2(0, 0));
            Entity.AddMovingSpeed(0);
        }
    }
}