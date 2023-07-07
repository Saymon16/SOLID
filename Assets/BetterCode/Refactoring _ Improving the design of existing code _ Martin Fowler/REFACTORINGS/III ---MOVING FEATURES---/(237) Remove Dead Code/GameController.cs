using UnityEngine;
using RemoveDeadCode;

namespace RemoveDeadCode_Before
{
    public class GameController : MonoBehaviour
    {
        public Player Player;
        private int _score;
        private int _highScore;

        // These two properties were replaced with a Player class but are still in the code
        private int _playerHealth;
        private int _playerAmmo;

        // This method is no longer being used as we have moved to a new scoring system
        public void CalculateScoreBasedOnTime(float time)
        {
            _score = Mathf.RoundToInt(time * 100);
            CheckForHighScore();
        }

        public void StartGame()
        {
            _playerHealth = 10;
            _playerAmmo = 100;
            Player.InitPlayer();
            for (int i = 0; i < 20; i++)
            {
                Enemy newEnemy = new Enemy();
                newEnemy.InitEnemy();
                newEnemy.OnDeath += OnEnemyKilled;
            }

            _score = 0;
            _highScore = PlayerPrefs.GetInt("HighScore", 0);
        }

        public void OnEnemyKilled()
        {
            _score += 100;
            CheckForHighScore();
        }

        private void CheckForHighScore()
        {
            if (_score > _highScore)
            {
                _highScore = _score;
                PlayerPrefs.SetInt("HighScore", _score);
            }
        }
    }

    namespace RemoveDeadCode_After
    {
        public class GameController : MonoBehaviour
        {
            public Player Player;
            private int _score;
            private int _highScore;

            public void StartGame()
            {
                Player.InitPlayer();
                for (int i = 0; i < 20; i++)
                {
                    Enemy newEnemy = new Enemy();
                    newEnemy.InitEnemy();
                    newEnemy.OnDeath += OnEnemyKilled;
                }

                _score = 0;
                _highScore = PlayerPrefs.GetInt("HighScore", 0);
            }

            public void OnEnemyKilled()
            {
                _score += 100;
                CheckForHighScore();
            }

            private void CheckForHighScore()
            {
                if (_score > _highScore)
                {
                    _highScore = _score;
                    PlayerPrefs.SetInt("HighScore", _score);
                }
            }
        }
    }
}