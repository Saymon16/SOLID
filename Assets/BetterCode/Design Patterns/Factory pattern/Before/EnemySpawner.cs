using UnityEngine;

namespace FactoryPattern_Before
{
    public class EnemySpawner : MonoBehaviour
    {
        private Enemy _enemy;

        public void SpawnEnemy(string enemyType)
        {
            switch (enemyType)
            {
                case "Orc":
                    _enemy = new Orc();
                    break;
                case "Troll":
                    _enemy = new Troll();
                    break;
                case "Goblin":
                    _enemy = new Goblin();
                    break;
            }
        }
    }
}