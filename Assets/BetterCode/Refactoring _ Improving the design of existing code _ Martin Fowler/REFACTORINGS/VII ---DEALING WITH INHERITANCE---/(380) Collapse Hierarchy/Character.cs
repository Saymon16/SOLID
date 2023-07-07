using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CollapseHierarchy_Before
{
    public class Character
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }

        public void TakeDamage(int damage)
        {
            HitPoints -= damage;
        }
    }

    public class Mage : Character
    {
        public void CastSpell()
        {
            Debug.Log("Mage casts a spell!");
        }
    }
}

namespace CollapseHierarchy_After
{
    public class Mage
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }

        public void TakeDamage(int damage)
        {
            HitPoints -= damage;
        }

        public void CastSpell()
        {
            Debug.Log("Mage casts a spell!");
        }
    }
}