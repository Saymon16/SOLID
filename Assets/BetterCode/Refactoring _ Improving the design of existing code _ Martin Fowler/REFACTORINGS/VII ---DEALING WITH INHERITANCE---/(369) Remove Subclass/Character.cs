using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RemoveSubclass_Before
{
    public abstract class Character
    {
        public abstract void Attack();
    }

    public class Mage : Character
    {
        public override void Attack()
        {
            Debug.Log("Mage attacks with magic!");
        }
    }

    public class Warrior : Character
    {
        public override void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }
}

namespace RemoveSubclass_After
{
    public class Character
    {
        public enum CharacterType
        {
            Mage,
            Warrior
        }

        private CharacterType type;

        public Character(CharacterType type)
        {
            this.type = type;
        }

        public void Attack()
        {
            switch (type)
            {
                case CharacterType.Mage:
                    Debug.Log("Mage attacks with magic!");
                    break;
                case CharacterType.Warrior:
                    Debug.Log("Warrior attacks with a sword!");
                    break;
            }
        }
    }
}