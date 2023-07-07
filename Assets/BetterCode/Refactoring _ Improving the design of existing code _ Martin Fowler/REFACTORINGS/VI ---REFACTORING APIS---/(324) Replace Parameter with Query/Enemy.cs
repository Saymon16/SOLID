using ReplaceParameterWithQuery;
using UnityEngine;

namespace ReplaceParameterWithQuery_Before
{
    public class Usage
    {
        public void EnemyAttacks(Player player)
        {
            var weapon = new Weapon(3);
            var enemy = new Enemy(weapon);
            enemy.Attack(player, weapon.Damage);
        }
    }

    public class Enemy
    {
        private Weapon _weapon;

        public Enemy(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(Player player, int damage)
        {
            player.Health -= damage;
        }
    }
}

namespace ReplaceParameterWithQuery_After
{
    public class Usage
    {
        public void EnemyAttacks(Player player)
        {
            new Enemy(new Weapon(3)).Attack(player);
        }
    }

    public class Enemy
    {
        private Weapon _weapon;

        public Enemy(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(Player player)
        {
            player.Health -= _weapon.Damage;
        }
    }
}