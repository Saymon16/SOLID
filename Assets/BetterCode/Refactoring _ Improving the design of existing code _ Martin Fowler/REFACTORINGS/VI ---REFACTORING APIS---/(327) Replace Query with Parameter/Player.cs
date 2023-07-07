using ReplaceQueryWithParameter;
using UnityEngine;

namespace ReplaceQueryWithParameter_Before
{
    public class Player
    {
        public Weapon EquippedWeapon { get; set; }

        public void Attack(Enemy enemy)
        {
            int damage = EquippedWeapon.GetDamage();
            enemy.TakeDamage(damage);
        }
    }
}

namespace ReplaceQueryWithParameter_After
{
    public class Player
    {
        public Weapon EquippedWeapon { get; set; }

        public void Attack(Enemy enemy, int damage)
        {
            enemy.TakeDamage(damage);
        }
    }
}