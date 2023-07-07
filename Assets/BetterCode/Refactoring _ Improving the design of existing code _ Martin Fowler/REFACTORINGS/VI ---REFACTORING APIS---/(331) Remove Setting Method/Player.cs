using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RemoveSettingMethod_Before
{
    public class Player
    {
        public int MaxHealth { get;  set; }

        public void SetMaxHealth(int maxHealth)
        {
            MaxHealth = maxHealth;
        }
    }
}

namespace RemoveSettingMethod_After
{
    public class Player
    {
        public int MaxHealth { get; }

        public Player(int maxHealth)
        {
            MaxHealth = maxHealth;
        }
    }
}