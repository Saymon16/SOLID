using UnityEngine;
using PreserveWholeObject;

namespace PreserveWholeObject_Before
{
    public class Usage
    {
        public void DamageEnemy(Enemy enemy, Weapon weapon)
        {
            enemy.TakeDamage(weapon.Damage, weapon.CriticalMultiplier);
        }
    }


    public class Enemy
    {
        public int Health { get; private set; }

        public void TakeDamage(int weaponDamage, float criticalMultiplier)
        {
            var damage = Mathf.CeilToInt(weaponDamage * criticalMultiplier);
            Health -= damage;
        }
    }
}

namespace PreserveWholeObject_After
{
    public class Usage
    {
        public void DamageEnemy(Enemy enemy, Weapon weapon)
        {
            enemy.TakeDamage(weapon);
        }
    }

    public class Enemy
    {
        public int Health { get; private set; }

        public void TakeDamage(Weapon weapon)
        {
            var damage = Mathf.CeilToInt(weapon.Damage * weapon.CriticalMultiplier);
            Health -= damage;
        }
    }
}