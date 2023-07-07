using System;
using UnityEngine;

namespace FactoryPattern_After
{
    public class EnemySpawner : MonoBehaviour
    {
        private Enemy _enemy;
        private EnemyFactory _enemyFactory;

        private void Start()
        {
            _enemyFactory = new EnemyFactory();
        }

        public void SpawnEnemy(string enemyType)
        {
            _enemy = _enemyFactory.CreateEnemy(enemyType);
        }
    }

    public class EnemyFactory
    {
        public Enemy CreateEnemy(string enemyType)
        {
            switch (enemyType)
            {
                case "Orc":
                    return new Orc();
                case "Troll":
                    return new Troll();
                case "Goblin":
                    return new Goblin();
                default:
                    throw new ArgumentException("Invalid enemy type", nameof(enemyType));
            }
        }
    }
}