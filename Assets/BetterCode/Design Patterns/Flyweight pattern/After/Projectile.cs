using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern_After
{
    public class ProjectileType
    {
        public float Acceleration;
        public float MaxVelocity;
        public int Damage;

        public ProjectileType(float acceleration, float maxVelocity, int damage)
        {
            Acceleration = acceleration;
            MaxVelocity = maxVelocity;
            Damage = damage;
        }
    }

    public class ProjectileInstance
    {
        public GameObject ProjectileObject;
        public ProjectileType ProjectileType;
        public Transform Target;
        public float Velocity;
        public Vector3 Direction;

        public ProjectileInstance(ProjectileType projectileType, GameObject projectileObject,  Transform target)
        {
            ProjectileObject = projectileObject;
            ProjectileType = projectileType;
            Target = target;
        }
    }

    public class Gun
    {
        public GameObject ProjectilePrefab;
        public ProjectileType ProjectileType;

        public List<ProjectileInstance> ActiveProjectiles;

        public Gun(GameObject projectilePrefab, float fireRate,  float projectileAcceleration, float projectileMaxVelocity, int projectileDamage)
        {
            ActiveProjectiles = new List<ProjectileInstance>();
            ProjectilePrefab = projectilePrefab;
            ProjectileType = new ProjectileType(projectileAcceleration, projectileMaxVelocity, projectileDamage);
        }

        public void Fire(Transform target)
        {
            var go = GameObject.Instantiate(ProjectilePrefab);
            ProjectileInstance newProjectile = new ProjectileInstance(ProjectileType, go, target);

            ActiveProjectiles.Add(newProjectile);
        }
    }
}