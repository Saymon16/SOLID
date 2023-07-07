using System;
using UnityEngine;


namespace PrototypePatter_After
{
    public class Enemy : ICloneable
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

        public object Clone()
        {
            GameObject clonedModel = UnityEngine.Object.Instantiate(Model);
            return new Enemy(clonedModel, Health, Speed);
        }
    }

    public class Spawner : MonoBehaviour
    {
        private Enemy _enemyPrototype;

        public void Start()
        {
            GameObject enemyModel = Resources.Load<GameObject>("EnemyModel");
            _enemyPrototype = new Enemy(enemyModel, 100, 2f);
        }

        public void SpawnEnemy()
        {
            Enemy newEnemy = (Enemy) _enemyPrototype.Clone();
        }
    }
}