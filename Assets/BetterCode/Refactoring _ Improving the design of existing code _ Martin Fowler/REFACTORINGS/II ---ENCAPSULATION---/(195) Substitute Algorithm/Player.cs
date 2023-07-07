using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using SubstituteAlgorithm;

namespace SubstituteAlgorithm_Before
{
    public class Player : MonoBehaviour
    {
        public List<Enemy> enemies;

        public Enemy FindClosestEnemy()
        {
            Enemy closestEnemy = null;
            float minDistance = Mathf.Infinity;
            foreach (var enemy in enemies)
            {
                float distanceToEnemy = Vector3.Distance(this.transform.position, enemy.Transform.position);
                if (distanceToEnemy < minDistance)
                {
                    minDistance = distanceToEnemy;
                    closestEnemy = enemy;
                }
            }

            return closestEnemy;
        }
    }
}

namespace SubstituteAlgorithm_After
{
    public class Player : MonoBehaviour
    {
        public List<Enemy> enemies;

        public Enemy FindClosestEnemy()
        {
            return enemies.OrderBy(enemy => Vector3.Distance(this.transform.position, enemy.Transform.position)).FirstOrDefault();
        }
    }
}