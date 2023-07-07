using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PullUpConstructorBody_Before
{
    public abstract class Character
    {
        protected int HitPoints;
        protected int PowerLevel;
    }

    public class Warrior : Character
    {
        public Warrior(int hitPoints, int powerLevel)
        {
            this.HitPoints = hitPoints;
            this.PowerLevel = powerLevel;
        }
    }

    public class Mage : Character
    {
        public Mage(int hitPoints, int powerLevel)
        {
            this.HitPoints = hitPoints;
            this.PowerLevel = powerLevel;
        }
    }
}

namespace PullUpConstructorBody_After
{
    public abstract class Character
    {
        protected int HitPoints;
        protected int PowerLevel;

        protected Character(int hitPoints, int powerLevel)
        {
            this.HitPoints = hitPoints;
            this.PowerLevel = powerLevel;
        }
    }

    public class Warrior : Character
    {
        public Warrior(int hitPoints, int powerLevel) : base(hitPoints, powerLevel)
        {
        }
    }

    public class Mage : Character
    {
        public Mage(int hitPoints, int powerLevel) : base(hitPoints, powerLevel)
        {
        }
    }
}