using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceTypeCodeWithSubclasses_Before
{
    public class Character
    {
        public enum Type
        {
            Warrior,
            Mage,
            Archer
        };

        public Type CharacterType;

        public Character(Type characterType)
        {
            CharacterType = characterType;
        }

        public void Attack()
        {
            switch (CharacterType)
            {
                case Type.Warrior:
                    Debug.Log("Warrior attacks with sword!");
                    break;
                case Type.Mage:
                    Debug.Log("Mage attacks with magic!");
                    break;
                case Type.Archer:
                    Debug.Log("Archer attacks with bow!");
                    break;
            }
        }
    }
}

namespace ReplaceTypeCodeWithSubclasses_After
{
    public abstract class Character
    {
        public abstract void Attack();
    }

    public class Warrior : Character
    {
        public override void Attack()
        {
            Debug.Log("Warrior attacks with sword!");
        }
    }

    public class Mage : Character
    {
        public override void Attack()
        {
            Debug.Log("Mage attacks with magic!");
        }
    }

    public class Archer : Character
    {
        public override void Attack()
        {
            Debug.Log("Archer attacks with bow!");
        }
    }
}