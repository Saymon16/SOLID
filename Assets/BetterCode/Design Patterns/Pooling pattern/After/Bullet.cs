using System;
using UnityEngine;

namespace PoolingPattern_After
{
    public class Bullet : PoolObject
    {
        public float Speed;
        public float LifeTime;
        private float _spawnTime;

        private void Init()
        {
            _spawnTime = Time.time;
        }

        private void Start()
        {
            Init();
        }

        public override void OnObjectReuse()
        {
            Init();
        }

        void Update()
        {
            transform.position += transform.forward * Speed;
            if (LifeTime < Time.time - _spawnTime)
                Dispose();
        }

        private void OnCollisionEnter(Collision other)
        {
            //Inflict damage to other
            Dispose();
        }
    }
}