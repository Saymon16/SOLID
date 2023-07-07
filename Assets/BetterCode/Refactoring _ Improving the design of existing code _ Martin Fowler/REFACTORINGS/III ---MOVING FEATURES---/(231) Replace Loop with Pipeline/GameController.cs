using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using ReplaceLoopWithPipeline;

namespace ReplaceLoopWithPipeline_Before
{
    public class GameController : MonoBehaviour
    {
        public List<Enemy> Enemies;

        public int CalculateScore()
        {
            int score = 0;
            foreach (Enemy enemy in Enemies)
            {
                if (enemy.IsDefeated)
                {
                    score += enemy.ScoreValue;
                }
            }

            return score;
        }
    }
}

namespace ReplaceLoopWithPipeline_After
{
    public class GameController : MonoBehaviour
    {
        public List<Enemy> Enemies;

        public int CalculateScore()
        {
            return Enemies.Where(enemy => enemy.IsDefeated).Sum(enemy => enemy.ScoreValue);
        }
    }
}