using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecomposeConditional_Before
{
    public class Player
    {
        public int BaseDamage { get; }
        public int Level { get; }
        public bool HasPowerUp { get; }

        public Player(int baseDamage, int level, bool hasPowerUp)
        {
            BaseDamage = baseDamage;
            Level = level;
            HasPowerUp = hasPowerUp;
        }

        public int CalculateDamage()
        {
            if (Level > 10 && HasPowerUp)
            {
                return BaseDamage * 2 + 10;
            }
            else
            {
                return BaseDamage;
            }
        }
    }
}

namespace DecomposeConditional_After
{
    public class Player
    {
        public int BaseDamage { get; }
        public int Level { get; }
        public bool HasPowerUp { get; }

        public Player(int baseDamage, int level, bool hasPowerUp)
        {
            BaseDamage = baseDamage;
            Level = level;
            HasPowerUp = hasPowerUp;
        }

        public int CalculateDamage()
        {
            if (IsEligibleForDamageBoost())
            {
                return CalculateBoostedDamage();
            }
            else
            {
                return BaseDamage;
            }
        }

        private bool IsEligibleForDamageBoost()
        {
            return Level > 10 && HasPowerUp;
        }

        private int CalculateBoostedDamage()
        {
            return BaseDamage * 2 + 10;
        }
    }
}