using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MoveStatementsIntoFunction_Before
{
    public class GameController : MonoBehaviour
    {
        private int _score;
        private Text _scoreDisplay;

        public void UpdateScoreOnEnemyKill()
        {
            _score += 10;
            _scoreDisplay.text = $"Score: {_score}";
        }

        public void UpdateScoreOnItemCollection()
        {
            _score += 5;
            _scoreDisplay.text = $"Score: {_score}";
        }
    }
}

namespace MoveStatementsIntoFunction_After
{
    public class GameController : MonoBehaviour
    {
        private int _score;
        private Text _scoreDisplay;

        public void UpdateScoreOnEnemyKill()
        {
            AddToScore(10);
        }

        public void UpdateScoreOnItemCollection()
        {
            AddToScore(5);
        }

        private void AddToScore(int increment)
        {
            _score += increment;
            _scoreDisplay.text = $"Score: {_score}";
        }
    }
}