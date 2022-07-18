using UnityEngine;

namespace Code.Behaviours
{
    public class HeroAnimator : MonoBehaviour
    {
        private readonly int _speedHash = Animator.StringToHash("Speed");
        
        [SerializeField]
        private Animator _animator;

        public void SetSpeed(float speed)
        {
            _animator.SetFloat(_speedHash, speed);
        }
    }
}