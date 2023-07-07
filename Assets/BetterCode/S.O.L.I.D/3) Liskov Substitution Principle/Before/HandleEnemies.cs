using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovSubstitutionPrinciple_Before
{
    public class HandleEnemies : MonoBehaviour
    {
        public void HandleEnemyBehaviours(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                enemy.Attack();
                if (enemy is RangedEnemy rangedEnemy)
                {
                    rangedEnemy.StayAtDistance();
                }

                if (enemy is SniperEnemy sniperEnemy)
                {
                    sniperEnemy.ActiveCamouflage();
                }
            }
        }
    }
}