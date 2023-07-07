using UnityEngine;

namespace MementoPattern_After
{
    public class Player
    {
        public PlayerData PlayerData;

        public void Move(Vector3 newPosition)
        {
            PlayerData.Position = newPosition;
        }

        public void TakeDamage(int damage)
        {
            PlayerData.Health -= damage;
        }

        public void CastSpell(int cost, bool costMana)
        {
            PlayerData.Mana -= cost;
        }

        public void Rest()
        {
            PlayerData.Health = PlayerData.HealthMax;
            PlayerData.Mana = PlayerData.ManaMax;
        }

        public PlayerMemento Save()
        {
            return new PlayerMemento(PlayerData);
        }

        public void Restore(PlayerMemento playerMemento)
        {
            PlayerData = playerMemento.PlayerData;
        }
    }

    public class PlayerMemento
    {
        public PlayerData PlayerData;

        public PlayerMemento(PlayerData playerData)
        {
            PlayerData = playerData;
        }
    }

    public struct PlayerData
    {
        public Vector3 Position;
        public int Health;
        public int HealthMax;
        public int Mana;
        public int ManaMax;
    }
}