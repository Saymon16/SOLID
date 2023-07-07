using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RemoveMiddleMan_Before
{
    public class Usage
    {
        public void DecreaseHealth(Player player)
        {
            player.DecreaseHealth(5);
        }
    }

    public class Player
    {
        public Health Health;

        public Player(int initialHealth)
        {
            Health = new Health(initialHealth);
        }

        public void DecreaseHealth(int amount)
        {
            Health.DecreaseHealth(amount);
        }
    }

    public class Health
    {
        public int CurrentHealth;

        public Health(int initialHealth)
        {
            CurrentHealth = initialHealth;
        }

        public void DecreaseHealth(int amount)
        {
            CurrentHealth -= amount;
            CurrentHealth = Mathf.Max(CurrentHealth, 0);
        }
    }
}

namespace RemoveMiddleMan_After
{
    public class Usage
    {
        public void DecreaseHealth(Player player)
        {
            player.Health.DecreaseHealth(5);
        }
    }

    public class Player
    {
        public Health Health;

        public Player(int initialHealth)
        {
            Health = new Health(initialHealth);
        }
    }

    public class Health
    {
        public int CurrentHealth;

        public Health(int initialHealth)
        {
            CurrentHealth = initialHealth;
        }

        public void DecreaseHealth(int amount)
        {
            CurrentHealth -= amount;
            CurrentHealth = Mathf.Max(CurrentHealth, 0);
        }
    }
}