using UnityEngine;

namespace OpenClosedPrinciple_Before
{
    public class Player : MonoBehaviour
    {
        public int Level;
        public int MaxHealth;
        public int MaxMana;

        public void LevelUp()
        {
            Level++;

            switch (Level)
            {
                case 2:
                    MaxHealth += 20;
                    MaxMana += 1;
                    break;
                case 3:
                    MaxHealth += 30;
                    MaxMana += 1;
                    break;
            }
        }
    }
}