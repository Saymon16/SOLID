using UnityEngine;

namespace IntroduceParameterObject_Before
{
    public class PlayerController : MonoBehaviour
    {
        public void ApplyPowerUp(int extraHealth, int extraSpeed, int extraDamage, bool isInvincible)
        {
            // Apply the power-up
        }
    }
}

namespace IntroduceParameterObject_After
{
    [System.Serializable]
    public class PowerUp
    {
        public int ExtraHealth;
        public int ExtraSpeed;
        public int ExtraDamage;
        public bool IsInvincible;
    }

    public class PlayerController : MonoBehaviour
    {
        public void ApplyPowerUp(PowerUp powerUp)
        {
            // Apply the power-up
        }
    }
}