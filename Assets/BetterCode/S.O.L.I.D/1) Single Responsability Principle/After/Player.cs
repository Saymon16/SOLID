using System;
using UnityEngine;
using UnityEngine.Events;

namespace SingleResponsibilityPrinciple_After
{
    public class Player : MonoBehaviour
    {
        public PlayerStats Stats;
        public event Action<PlayerStats> OnPlayerDamaged;

        public void TakeDamage(int damage)
        {
            Stats.Health -= damage;
            OnPlayerDamaged?.Invoke(Stats);
        }
    }

    [Serializable]
    public class PlayerStats
    {
        public int Level;
        public int Health;
    }
}