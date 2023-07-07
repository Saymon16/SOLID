using System;
using UnityEngine;

namespace PoolingPattern_Before
{
    public class Bullet : MonoBehaviour
    {
        public float Speed;
        public float LifeTime;
        private float _spawnTime;

        private void Start()
        {
            _spawnTime = Time.time;
        }

        void Update()
        {
            transform.position += transform.forward * Speed;
            if (LifeTime < Time.time - _spawnTime)
                DestroyBullet();
        }

        private void OnCollisionEnter(Collision other)
        {
            //Inflict damage to other
            DestroyBullet();
        }

        void DestroyBullet()
        {
            Destroy(gameObject);
        }
    }
}