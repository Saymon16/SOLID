using UnityEngine;
using UnityEngine.UI;

namespace SingleResponsibilityPrinciple_Before
{
    public class Player : MonoBehaviour
    {
        public int Level;
        public int Health;
        public Text PlayerStatsText;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            UpdatePlayerStatsUI();
        }

        private void UpdatePlayerStatsUI()
        {
            PlayerStatsText.text = $"Level: {Level}, Health: {Health}";
        }
    }
}