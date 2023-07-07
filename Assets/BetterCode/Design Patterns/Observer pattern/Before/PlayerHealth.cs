using UnityEngine;

namespace SingletonPattern_Before
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private GameObject _gameOverUI;

        private AchievementManager _achievementManager;

        private void Awake()
        {
            _achievementManager =  FindAnyObjectByType<AchievementManager>();
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health <= 0)
            {
                _gameOverUI.SetActive(true);
                _achievementManager.UnlockDeathAchievement();
            }
        }
    }

    public class AchievementManager : MonoBehaviour
    {
        public void UnlockDeathAchievement()
        {
        }
    }
}