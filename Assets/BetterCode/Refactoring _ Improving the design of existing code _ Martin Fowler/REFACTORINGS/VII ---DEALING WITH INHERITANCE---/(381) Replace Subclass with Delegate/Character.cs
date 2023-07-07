using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceSubclassWithDelegate_Before
{
    public abstract class Character
    {
        public abstract void Attack();
    }

    public class Warrior : Character
    {
        public override void Attack()
        {
            Debug.Log("Warrior swings sword!");
        }
    }
}

namespace ReplaceSubclassWithDelegate_After
{
    public class Usage
    {
        public void Attack()
        {
            Character warrior = new Character();
            warrior.AttackBehavior = () => Debug.Log("Warrior swings sword!");
            warrior.Attack();
        }
    }

    public class Character
    {
        public delegate void AttackDelegate();

        public AttackDelegate AttackBehavior { get; set; }

        public void Attack()
        {
            AttackBehavior?.Invoke();
        }
    }
}