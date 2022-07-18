using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Random = UnityEngine.Random;

namespace Code.Behaviours
{
    public class FlickeringLight : MonoBehaviour
    {
        [SerializeField] 
        private Light2D _light2D;

        private float intensity;
        
        private void Start()
        {
            intensity = _light2D.intensity;
            
            StartCoroutine(Flicker());
        }

        private IEnumerator Flicker()
        {
            while (true)
            {
                _light2D.intensity = intensity;
                yield return new WaitForSeconds(Random.Range(3, 5));
                _light2D.intensity = Random.Range(0.5f, intensity);
                yield return new WaitForSeconds(0.05f);
                _light2D.intensity = Random.Range(0.5f, intensity);
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}