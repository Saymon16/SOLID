using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SeparateQueryFromModifier_Before
{
    public class Player
    {
        public int Health { get; private set; }
        public bool IsAlive => Health > 0;

        public bool CheckStatusAndTakeDamage(int damage)
        {
            if (IsAlive)
            {
                Health -= damage;
            }

            return IsAlive;
        }
    }
}

namespace SeparateQueryFromModifier_After
{
    public class Player
    {
        public int Health { get; private set; }
        public bool IsAlive => Health > 0;

        public bool CheckStatus()
        {
            return IsAlive;
        }

        public void TakeDamage(int damage)
        {
            if (IsAlive)
            {
                Health -= damage;
            }
        }
    }
}