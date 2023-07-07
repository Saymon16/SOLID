using System.Collections.Generic;
using UnityEngine;

namespace OpenClosedPrinciple_After
{
    public class Player : MonoBehaviour
    {
        public int Level;
        public int Health;

        private List<ILevelUpBonusPolicy> _levelUpBonusPolicies;

        public void InitializeLevelUpBonusPolicies()
        {
            _levelUpBonusPolicies = Utilities.GetAllClassesInheritingFrom<ILevelUpBonusPolicy>();
        }

        public void LevelUp()
        {
            Level++;

            foreach (var policy in _levelUpBonusPolicies)
            {
                if (policy.AppliesTo(Level))
                {
                    Health += policy.GetBonusHealth();
                    break;
                }
            }
        }
    }
}