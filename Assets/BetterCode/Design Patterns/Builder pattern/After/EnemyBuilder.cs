using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BuilderPattern_After
{
    public class EnemyBuilder
    {
        private string _type = "Default";
        private int _health = 100;
        private float _speed = 10f;
        private Weapon _weapon = new Weapon();
        private float _size = 1.5f;

        public EnemyBuilder WithType(string type)
        {
            _type = type;
            return this;
        }

        public EnemyBuilder WithHealth(int health)
        {
            _health = health;
            return this;
        }

        public EnemyBuilder WithSpeed(float speed)
        {
            _speed = speed;
            return this;
        }

        public EnemyBuilder WithWeapon(Weapon weapon)
        {
            _weapon = weapon;
            return this;
        }

        public EnemyBuilder WithSize(float size)
        {
            _size = size;
            return this;
        }

        public Enemy Build()
        {
            return new Enemy(_type, _health, _speed, _weapon, _size);
        }
    }
}