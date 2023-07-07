using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StrategyPattern_After
{
    public class Enemy
    {
        public int Health;
        public IBehavior CurrentBehavior;

        public Enemy(int health)
        {
            Health = health;
            CurrentBehavior = new AggressiveBehavior();
        }

        public void Behave()
        {
            CurrentBehavior.Behave();
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 30)
            {
                CurrentBehavior = new DefensiveBehavior();
            }
            else if (Health < 10)
            {
                CurrentBehavior = new PassiveBehavior();
            }
        }
    }

    public interface IBehavior
    {
        void Behave();
    }

    public class PassiveBehavior : IBehavior
    {
        public void Behave()
        {
            Debug.Log("Avoiding conflict.");
        }
    }

    public class DefensiveBehavior : IBehavior
    {
        public void Behave()
        {
            Debug.Log("Defending position.");
        }
    }

    public class AggressiveBehavior : IBehavior
    {
        public void Behave()
        {
            Debug.Log("Attacking the player.");
        }
    }
}