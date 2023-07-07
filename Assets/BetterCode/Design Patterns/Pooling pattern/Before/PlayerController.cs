using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PoolingPattern_Before
{
    public class PlayerController : MonoBehaviour
    {
        public GameObject BulletPrefab;
        public Transform Barrel;
        public float BulletSpeed;
        public float BulletLifeTime;

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                var bulletGO =  Instantiate(BulletPrefab, Barrel.position, Barrel.rotation);
                var bulletComponent = bulletGO.GetComponent<Bullet>();
                bulletComponent.Speed = BulletSpeed;
                bulletComponent.LifeTime = BulletLifeTime;
            }
        }
    }
}