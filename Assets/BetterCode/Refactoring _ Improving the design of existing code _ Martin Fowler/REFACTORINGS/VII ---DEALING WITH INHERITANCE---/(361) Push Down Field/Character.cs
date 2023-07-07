using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PushDownField_Before
{
    public abstract class Character
    {
        protected int hitPoints;
        protected int mana;
        protected int rage;
    }

    public class Mage : Character
    {
    }

    public class Warrior : Character
    {
    }
}

namespace PushDownField_After
{
    public abstract class Character
    {
        protected int hitPoints;
    }

    public class Warrior : Character
    {
        protected int rage;
    }

    public class Mage : Character
    {
        protected int mana;
    }
}