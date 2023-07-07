using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryPattern_After
{
    public class Enemy
    {
        public float Health;

        public void TakeDamage()
        {
        }
    }

    public class Orc : Enemy
    {
        public void Charge()
        {
        }
    }

    public class Troll : Enemy
    {
        public void Stomp()
        {
        }
    }

    public class Goblin : Enemy
    {
        public void Sneak()
        {
        }
    }
}