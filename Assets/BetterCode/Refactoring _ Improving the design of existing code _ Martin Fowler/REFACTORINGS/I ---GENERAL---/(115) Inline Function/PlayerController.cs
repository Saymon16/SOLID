using UnityEngine;

namespace InlineFunction_Before
{
    public class PlayerController : MonoBehaviour
    {
        private int mana = 100;

        public void PerformSpecialAbility()
        {
            if (CanPerformSpecialAbility())
            {
                // Perform the special ability
                mana -= 50;
            }
        }

        private bool CanPerformSpecialAbility()
        {
            return mana >= 50;
        }
    }
}

namespace InlineFunction_After
{
    public class PlayerController : MonoBehaviour
    {
        private int mana = 100;

        public void PerformSpecialAbility()
        {
            if (mana >= 50)
            {
                // Perform the special ability
                mana -= 50;
            }
        }
    }
}