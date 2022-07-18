using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Behaviours
{
    public class LevelProvider : MonoBehaviour
    {
        public void LoadScene(int index)
        {
            SceneManager.LoadScene(index);
        }
    }
}