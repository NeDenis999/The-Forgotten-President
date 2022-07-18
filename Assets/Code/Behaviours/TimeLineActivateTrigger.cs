using System;
using UnityEngine;
using UnityEngine.Playables;

namespace Code.Behaviours
{
    public class TimeLineActivateTrigger : MonoBehaviour
    {
        [SerializeField] 
        private PlayableDirector _playableDirector;

        private void OnTriggerEnter2D(Collider2D other)
        {
            _playableDirector.Play();
        }
    }
}