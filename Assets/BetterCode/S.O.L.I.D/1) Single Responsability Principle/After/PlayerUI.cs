using UnityEngine;
using UnityEngine.UI;

namespace SingleResponsibilityPrinciple_After
{
    public class PlayerUI : MonoBehaviour
    {
        public  Player Player;
        public Text PlayerStatsText;

        void Start()
        {
            Player.OnPlayerDamaged += UpdatePlayerStatsUI;
        }

        private void UpdatePlayerStatsUI(PlayerStats stats)
        {
            PlayerStatsText.text = $"Level: {stats.Level}, Health: {stats.Health}";
        }
    }
}