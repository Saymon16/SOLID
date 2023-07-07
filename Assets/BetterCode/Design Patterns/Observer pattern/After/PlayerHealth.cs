using System;
using UnityEngine;

namespace ObserverPattern_After
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private int _health;

        public static event Action OnPlayerDeath;

        public void TakeDamage(int damage)
        {
            _health -= damage;

            if (_health <= 0)
            {
                OnPlayerDeath?.Invoke();
            }
        }
    }

    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverUI;

        void OnEnable()
        {
            PlayerHealth.OnPlayerDeath += ShowGameOverUI;
        }

        void OnDisable()
        {
            PlayerHealth.OnPlayerDeath -= ShowGameOverUI;
        }

        void ShowGameOverUI()
        {
            _gameOverUI.SetActive(true);
        }
    }

    public class AchievementManager : MonoBehaviour
    {
        void OnEnable()
        {
            PlayerHealth.OnPlayerDeath += UnlockDeathAchievement;
        }

        void OnDisable()
        {
            PlayerHealth.OnPlayerDeath -= UnlockDeathAchievement;
        }

        void UnlockDeathAchievement()
        {
        }
    }
}