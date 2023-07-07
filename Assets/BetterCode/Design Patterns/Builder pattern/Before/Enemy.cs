using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuilderPattern_Before
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
            var enemy = new Enemy("Orc", 100, 10f, new Weapon { Name = "Axe", Damage = 20 }, 1.5f);
        }
    }
}