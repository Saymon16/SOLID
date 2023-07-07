using UnityEngine;

namespace RemoveFlagArgument_Before
{
    public class Enemy
    {
        public int Health { get; private set; }

        public void TakeDamage(int damage, bool isCritical)
        {
            if (isCritical)
            {
                Health -= damage * 2;
            }
            else
            {
                Health -= damage;
            }
        }
    }
}

namespace RemoveFlagArgument_After
{
    public class Enemy
    {
        public int Health { get; private set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void TakeCriticalDamage(int damage)
        {
            Health -= damage * 2;
        }
    }
}