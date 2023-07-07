using UnityEngine;

namespace ChangeFunctionDeclaration_Before
{
    public class PlayerController : MonoBehaviour
    {
        public int health = 100;

        void IncreaseHealth(int value, bool isDouble)
        {
            if (isDouble)
            {
                health += ( value * 2 );
            }
            else
            {
                health += value;
            }
        }
    }
}

namespace ChangeFunctionDeclaration_After
{
    public class PlayerController : MonoBehaviour
    {
        public int health = 100;

        void IncreaseHealth(int value)
        {
            health += value;
        }

        void IncreaseHealthDouble(int value)
        {
            health += ( value * 2 );
        }
    }
}