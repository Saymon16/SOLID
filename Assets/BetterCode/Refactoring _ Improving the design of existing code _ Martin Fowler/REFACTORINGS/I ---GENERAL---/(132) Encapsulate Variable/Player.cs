using UnityEngine;

namespace EncapsulateVariable_Before
{
    public class Player : MonoBehaviour
    {
        public int Health;
    }
}

namespace EncapsulateVariable_After
{
    public class Player : MonoBehaviour
    {
        private int _health;

        public int GetHealth() => _health;

        public void SetHealth(int value) => _health = Mathf.Max(0, value);
    }
}