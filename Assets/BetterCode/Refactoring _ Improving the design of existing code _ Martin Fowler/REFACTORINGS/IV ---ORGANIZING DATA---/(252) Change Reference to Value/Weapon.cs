using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChangeReferenceToValue_Before
{
    public class Weapon
    {
        public int Damage { get; set; }

        public Weapon(int damage)
        {
            Damage = damage;
        }

        public void UpgradeDamage(int additionalDamage)
        {
            Damage += additionalDamage;
        }
    }
}

namespace ChangeReferenceToValue_After
{
    public class Weapon
    {
        public int Damage { get; }

        public Weapon(int damage)
        {
            Damage = damage;
        }

        public Weapon UpgradeDamage(int additionalDamage)
        {
            return new Weapon(Damage + additionalDamage);
        }
    }
}