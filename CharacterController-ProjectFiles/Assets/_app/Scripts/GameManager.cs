using UnityEngine;

namespace _app.Scripts
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        [SerializeField]
        private int playerScore;

        private void Awake()
        {
            if (instance != null)
            {
                Destroy(obj:this);
            }
            if (instance == null)
            {
                instance = this;
            }
        }

        public void IncreaseScore()
        {
            playerScore++;
        }
    }
}