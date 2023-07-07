using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PullUpMethod_Before
{
    public abstract class Character
    {
        public int Health;
        public int HealthMax;
    }

    public class Warrior : Character
    {
        public int Rage;
        public int RageMax;

        public void Attack()
        {
            Rage = Mathf.Min(RageMax, Rage + 5);
            Debug.Log("Warrior attacks!");
        }

        public void Meditate()
        {
            Health = Mathf.Min(HealthMax, Health + Rage);
            Rage = 0;
            Debug.Log("Warrior meditates!");
        }
    }

    public class Mage : Character
    {
        public float Mana;
        public float ManaMax;

        public void Attack()
        {
            Mana = Mathf.Max(0, Mana - 1);
            Debug.Log("Mage attacks!");
        }

        public void Meditate()
        {
            Mana = ManaMax;
            Health = Mathf.Max(0, Health - 3);
            Debug.Log("Mage meditates!");
        }
    }
}

namespace PullUpMethod_After
{
    public enum AttackType
    {
        BasicAttack,
        Meditation
    }

    public abstract class Character
    {
        public int Health;
        public int HealthMax;

        public abstract void ClassResourceModification(AttackType attackType);

        public virtual void Attack()
        {
            ClassResourceModification(AttackType.BasicAttack);
            Debug.Log($"{GetType().Name} attacks!");
        }

        public virtual void Meditate()
        {
            ClassResourceModification(AttackType.Meditation);
            Debug.Log($"{GetType().Name} meditates!");
        }
    }

    public class Warrior : Character
    {
        public int Rage;
        public int RageMax;

        public override void ClassResourceModification(AttackType attackType)
        {
            Rage = attackType switch
            {
                AttackType.BasicAttack => Mathf.Min(RageMax, Rage + 5),
                AttackType.Meditation => 0,
                _ => Rage
            };
        }

        public override void Meditate()
        {
            base.Meditate();
            Health = Mathf.Min(HealthMax, Health + Rage);
        }
    }

    public class Mage : Character
    {
        public int Mana;
        public int ManaMax;

        public override void ClassResourceModification(AttackType attackType)
        {
            Mana = attackType switch
            {
                AttackType.BasicAttack => Mathf.Max( 0, Mana - 2),
                AttackType.Meditation => ManaMax,
                _ => Mana
            };
        }

        public override void Meditate()
        {
            base.Meditate();
            Health = Mathf.Max(0, Health - 3);
        }
    }
}