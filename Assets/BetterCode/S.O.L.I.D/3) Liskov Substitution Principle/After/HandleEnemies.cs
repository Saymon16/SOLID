using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovSubstitutionPrinciple_After
{
    public class HandleEnemies : MonoBehaviour
    {
        public void HandleEnemyBehaviours(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                enemy.Attack();
                enemy.StayAtDistance();
                enemy.ActiveCamouflage();
            }
        }
    }
}