using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern_Before
{
    public class Enemy
    {
        public int Health;
        public string CurrentBehavior;

        public Enemy(int health)
        {
            Health = health;
            CurrentBehavior = "Aggressive";
        }

        public void Behave()
        {
            if (CurrentBehavior == "Passive")
            {
                Debug.Log("Avoiding conflict.");
            }
            else if (CurrentBehavior == "Defensive")
            {
                Debug.Log("Defending position.");
            }
            else if (CurrentBehavior == "Aggressive")
            {
                Debug.Log("Attacking the player.");
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 30)
            {
                CurrentBehavior = "Defensive";
            }
            else if (Health < 10)
            {
                CurrentBehavior = "Passive";
            }
        }
    }
}