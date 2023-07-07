using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PullUpField_Before
{
    public abstract class Character
    {
    }

    public class Warrior : Character
    {
        public int hitPoints;

        public Warrior(int hitPoints)
        {
            this.hitPoints = hitPoints;
        }

        // other warrior-specific methods...
    }

    public class Mage : Character
    {
        public int hitPoints;

        public Mage(int hitPoints)
        {
            this.hitPoints = hitPoints;
        }

        // other mage-specific methods...
    }
}

namespace PullUpField_After
{
    public abstract class Character
    {
        protected int hitPoints;

        protected Character(int hitPoints)
        {
            this.hitPoints = hitPoints;
        }
    }

    public class Warrior : Character
    {
        public Warrior(int hitPoints) : base(hitPoints)
        {
        }
        // other warrior-specific methods...
    }

    public class Mage : Character
    {
        public Mage(int hitPoints) : base(hitPoints)
        {
        }
        // other mage-specific methods...
    }

}