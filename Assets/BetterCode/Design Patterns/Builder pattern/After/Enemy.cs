using UnityEngine;

namespace BuilderPattern_After
{
    public class Enemy
    {
        public string Type;
        public int Health;
        public float Speed;
        public Weapon Weapon;
        public float Size;

        public Enemy(string type, int health, float speed, Weapon weapon, float size)
        {
            Type = type;
            Health = health;
            Speed = speed;
            Weapon = weapon;
            Size = size;
        }
    }

    public class Weapon
    {
        public string Name;
        public int Damage;
    }

    public class UseCase : MonoBehaviour
    {
        private void Start()
        {
            var enemyBuilder = new EnemyBuilder();
            var enemy = enemyBuilder
                .WithWeapon(new Weapon { Name = "Axe", Damage = 20 })
                .WithSize(1f)
                //.WithHealth(150)
                .WithType("Orc")
                .Build();
        }
    }
}