using UnityEngine;

namespace RenameVariable_Before
{
    public class PlayerController : MonoBehaviour
    {
        public int s = 100;

        public void TakeDamage(int damage)
        {
            s -= damage;
            if (s < 0) s = 0;
        }
    }
}

namespace RenameVariable_After
{
    public class PlayerController : MonoBehaviour
    {
        public int Health = 100;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }
    }
}