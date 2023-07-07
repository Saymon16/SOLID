using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SplitLoop;
using UnityEngine.UI;

namespace SplitLoop_Before
{
    public class Player : MonoBehaviour
    {
        public List<Enemy> enemies;

        public void UpdateEnemies()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Health -= 10;
                enemy.Ammo += 5;
            }
        }
    }
}

namespace SplitLoop_After
{
    public class Player : MonoBehaviour
    {
        public List<Enemy> enemies;

        public void UpdateEnemies()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Health -= 10;
            }

            foreach (Enemy enemy in enemies)
            {
                enemy.Ammo += 5;
            }
        }
    }
}