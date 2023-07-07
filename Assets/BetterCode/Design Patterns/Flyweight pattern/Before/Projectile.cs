using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern_Before
{
    public class Projectile
    {
        public GameObject ProjectileObject;
        public float Acceleration;
        public float MaxVelocity;
        public int Damage;

        public Transform Target;
        public float Velocity;
        public Vector3 Direction;

        public Projectile(GameObject projectileObject, Transform target, float acceleration, float maxVelocity, int damage)
        {
            ProjectileObject = projectileObject;
            Acceleration = acceleration;
            MaxVelocity = maxVelocity;
            Damage = damage;
            Target = target;
        }
    }

    public class Gun
    {
        public GameObject ProjectilePrefab;
        public float ProjectileAcceleration;
        public float ProjectileMaxVelocity;
        public int ProjectileDamage;

        public List<Projectile> ActiveProjectiles;

        public Gun(GameObject projectilePrefab, float fireRate,  float projectileAcceleration, float projectileMaxVelocity, int projectileDamage)
        {
            ActiveProjectiles = new List<Projectile>();
            ProjectileAcceleration = projectileAcceleration;
            ProjectileMaxVelocity = projectileMaxVelocity;
            ProjectileDamage = projectileDamage;
            ProjectilePrefab = projectilePrefab;
        }

        public void Fire(Transform target)
        {
            var go = GameObject.Instantiate(ProjectilePrefab);
            Projectile newProjectile = new Projectile(go, target,  ProjectileAcceleration, ProjectileMaxVelocity, ProjectileDamage);

            ActiveProjectiles.Add(newProjectile);
        }
    }
}