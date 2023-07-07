using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExtractSuperclass_Before
{
    public class Mage
    {
        public string name;
        public int hitPoints;

        public void TakeDamage(int damage)
        {
            hitPoints -= damage;
        }

        public void CastSpell()
        {
            // Mage specific method
        }
    }

    public class Warrior
    {
        public string name;
        public int hitPoints;

        public void TakeDamage(int damage)
        {
            hitPoints -= damage;
        }

        public void SwingSword()
        {
            // Warrior specific method
        }
    }
}

namespace ExtractSuperclass_After
{
    public abstract class Character
    {
        public string name;
        public int hitPoints;

        public void TakeDamage(int damage)
        {
            hitPoints -= damage;
        }
    }

    public class Mage : Character
    {
        public void CastSpell()
        {
            // Mage specific method
        }
    }

    public class Warrior : Character
    {
        public void SwingSword()
        {
            // Warrior specific method
        }
    }
}