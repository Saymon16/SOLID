using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceConditionalWithPolymorphism_Before
{
    public class Usage
    {
        private Character _character;

        public void Initialize()
        {
            _character = new Character(Character.CharacterType.Warrior, 15);
        }

        public void Attack()
        {
            int damage =  _character.Attack();
        }
    }

    public class Character
    {
        public enum CharacterType
        {
            Warrior,
            Mage,
            Rogue
        }

        public CharacterType Type { get; }
        public int AttackPower { get; }

        public Character(CharacterType type, int attackPower)
        {
            Type = type;
            AttackPower = attackPower;
        }

        public int Attack()
        {
            switch (Type)
            {
                case CharacterType.Warrior:
                    return AttackPower * 2;
                case CharacterType.Mage:
                    return AttackPower * 3;
                case CharacterType.Rogue:
                    return AttackPower * 1;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

namespace ReplaceConditionalWithPolymorphism_After
{
    public class Usage
    {
        private Character _character;

        public void Initialize()
        {
            _character = new Warrior(15);
        }

        public void Attack()
        {
            int damage =  _character.Attack();
        }
    }

    public abstract class Character
    {
        public int AttackPower { get; }

        protected Character(int attackPower)
        {
            AttackPower = attackPower;
        }

        public abstract int Attack();
    }

    public class Warrior : Character
    {
        public Warrior(int attackPower) : base(attackPower)
        {
        }

        public override int Attack()
        {
            return AttackPower * 2;
        }
    }

    public class Mage : Character
    {
        public Mage(int attackPower) : base(attackPower)
        {
        }

        public override int Attack()
        {
            return AttackPower * 3;
        }
    }

    public class Rogue : Character
    {
        public Rogue(int attackPower) : base(attackPower)
        {
        }

        public override int Attack()
        {
            return AttackPower * 1;
        }
    }
}