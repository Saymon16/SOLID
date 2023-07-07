using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceSuperclassWithDelegate_Before
{
    public class Character
    {
        public virtual void Attack()
        {
            Debug.Log("Character attacks!");
        }

        public void Heal()
        {
            Debug.Log("Character heals!");
        }
    }

    public class Warrior : Character
    {
        public override void Attack()
        {
            Debug.Log("Warrior swings sword!");
        }

        public void ShieldBlock()
        {
            Debug.Log("Warrior blocks with shield!");
        }
    }

}

namespace ReplaceSuperclassWithDelegate_After
{
    public class Character
    {
        public void Attack()
        {
            Debug.Log("Character attacks!");
        }

        public void Heal()
        {
            Debug.Log("Character heals!");
        }
    }

    public class Warrior
    {
        private Character character = new Character();

        public void Attack()
        {
            character.Attack();  // Delegate the attack to the Character instance
        }

        public void ShieldBlock()
        {
            Debug.Log("Warrior blocks with shield!");
        }
    }

}