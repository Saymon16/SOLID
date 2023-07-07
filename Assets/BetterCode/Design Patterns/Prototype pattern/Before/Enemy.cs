using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePatter_Before
{
    public class Enemy
    {
        public GameObject Model;
        public int Health;
        public float Speed;

        public Enemy(GameObject model, int health, float speed)
        {
            Model = model;
            Health = health;
            Speed = speed;
        }
    }

    public class Spawner : MonoBehaviour
    {
        public void SpawnEnemy()
        {
            GameObject enemyModel = Resources.Load<GameObject>("EnemyModel");
            Enemy newEnemy = new Enemy(enemyModel, 100, 2f);
        }
    }
}