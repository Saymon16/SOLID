using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PushDownMethod_Before
{
    public abstract class Character
    {
        public void CastSpell()
        {
            Debug.Log("Character casts a spell!");
        }

        public void ThrowAxe()
        {
            Debug.Log("Character throws an axe!");
        }
    }

    public class Warrior : Character
    {
    }

    public class Mage : Character
    {
    }
}

namespace PushDownMethod_After
{
    public abstract class Character
    {
        // Other common methods and properties for all characters
    }

    public class Warrior : Character
    {
        public void ThrowAxe()
        {
            Debug.Log("Warrior throws an axe!");
        }
    }

    public class Mage : Character
    {
        public void CastSpell()
        {
            Debug.Log("Mage casts a spell!");
        }
    }
}