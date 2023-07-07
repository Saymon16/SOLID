using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConsolidateConditionalExpression_Before
{
    public class Player
    {
        public int Health { get; private set; }
        public bool HasShield { get; }

        // ...

        public void ReceiveDamage(int damage)
        {
            bool canReceiveDamage = true;

            if (Health <= 0) canReceiveDamage = false;
            if (HasShield) canReceiveDamage = false;

            if (canReceiveDamage)
                Health -= damage;
        }
    }
}

namespace ConsolidateConditionalExpression_After
{
    public class Player
    {
        public int Health { get; private set; }
        public bool HasShield { get; }

        // ...

        public void ReceiveDamage(int damage)
        {
            if (CanReceiveDamage())
                Health -= damage;
        }

        private bool CanReceiveDamage()
        {
            return !HasShield && Health > 0;
        }
    }
}