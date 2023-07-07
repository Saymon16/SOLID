using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceNestedConditionalWithGuardClauses_Before
{
    public class Player
    {
        public int Level { get; }
        public int BasePoints { get; }

        public Player(int level, int basePoints)
        {
            Level = level;
            BasePoints = basePoints;
        }

        public int CalculateBonusPoints()
        {
            if (Level >= 10)
            {
                if (BasePoints >= 1000)
                {
                    if (BasePoints >= 100000)
                    {
                        return BasePoints * 3;
                    }
                    else
                    {
                        return BasePoints * 2;
                    }
                }
                else
                {
                    return BasePoints + 100;
                }
            }
            else
            {
                return BasePoints;
            }
        }
    }
}

namespace ReplaceNestedConditionalWithGuardClauses_After
{
    public class Player
    {
        public int Level { get; }
        public int BasePoints { get; }

        public Player(int level, int basePoints)
        {
            Level = level;
            BasePoints = basePoints;
        }

        public int CalculateBonusPoints()
        {
            if (Level < 10) return BasePoints;
            if (BasePoints < 1000) return BasePoints + 100;
            if (BasePoints < 100000) return BasePoints * 2;

            return BasePoints * 3;
        }
    }
}