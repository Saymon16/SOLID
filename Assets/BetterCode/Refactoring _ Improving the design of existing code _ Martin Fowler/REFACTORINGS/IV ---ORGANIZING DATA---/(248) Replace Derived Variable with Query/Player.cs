using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceDerivedVariableWithQuery_Before
{
    public class Player
    {
        private int experiencePoints;
        private int level;

        public void GainExperience(int points)
        {
            experiencePoints += points;
            level = experiencePoints / 1000;
        }

        public void SpendExperience(int points)
        {
            experiencePoints -= points;
            level = experiencePoints / 1000;
        }

        // other methods...
    }
}

namespace ReplaceDerivedVariableWithQuery_After
{
    public class Player
    {
        private int experiencePoints;

        public int Level => experiencePoints / 1000;

        public void GainExperience(int points)
        {
            experiencePoints += points;
        }

        public void SpendExperience(int points)
        {
            experiencePoints -= points;
        }

        // other methods...
    }
}