using UnityEngine;

namespace MementoPattern_Before
{
    public class Player
    {
        public Vector3 Position;
        public int Health;
        public int HealthMax;
        public int Mana;
        public int ManaMax;

        public void Move(Vector3 newPosition)
        {
            Position = newPosition;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void CastSpell(int cost)
        {
            Mana -= cost;
        }

        public void Rest()
        {
            Health = HealthMax;
            Mana = ManaMax;
        }

        public Player Save()
        {
            Player result = new Player();
            result.Position = Position;
            result.Health = Health;
            result.HealthMax = HealthMax;
            result.Mana = Mana;
            result.ManaMax = ManaMax;
            return result;
        }

        public void Restore(Player player)
        {
            Position = player.Position;
            Health = player.Health;
            HealthMax = player.HealthMax;
            Mana = player.Mana;
            ManaMax = player.ManaMax;
        }
    }
}