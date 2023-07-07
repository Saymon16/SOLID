using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PoolingPattern_After
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject BulletPrefab;
        public Transform Barrel;
        public float BulletSpeed;
        public float BulletLifeTime;


        void Start()
        {
            PoolManager.instance.CreatePool(BulletPrefab, 50);
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                var bulletGO = PoolManager.instance.ReuseObject(BulletPrefab, Barrel.position, Barrel.rotation);
                var bulletComponent = bulletGO.GetComponent<Bullet>();
                bulletComponent.Speed = BulletSpeed;
                bulletComponent.LifeTime = BulletLifeTime;
            }
        }
    }
}