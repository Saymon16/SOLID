using UnityEngine;

namespace CombineFunctionsIntoClass_Before
{
    public class PlayerController : MonoBehaviour
    {
        private int _health = 100;

        public void ApplyDamage(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
        }

        public void ApplyHealthPack(int healthGain)
        {
            _health += healthGain;
            if (_health > 100)
            {
                _health = 100;
            }
        }

        public int GetCurrentHealth()
        {
            return _health;
        }
    }
}

namespace CombineFunctionsIntoClass_After
{
    public class PlayerController : MonoBehaviour
    {
        private HealthManager _healthManager;

        private void Start()
        {
            _healthManager = new HealthManager(100);
        }

        public void TakeDamage(int damage)
        {
            _healthManager.ApplyDamage(damage);
        }

        public void UseHealthPack(int healthGain)
        {
            _healthManager.ApplyHealthPack(healthGain);
        }

        public int GetCurrentHealth()
        {
            return _healthManager.GetCurrentHealth();
        }
    }

    public class HealthManager
    {
        private int _health;

        public HealthManager(int initialHealth)
        {
            _health = initialHealth;
        }

        public void ApplyDamage(int damage)
        {
            _health -= damage;
            if (_health < 0)
            {
                _health = 0;
            }
        }

        public void ApplyHealthPack(int healthGain)
        {
            _health += healthGain;
            if (_health > 100)
            {
                _health = 100;
            }
        }

        public int GetCurrentHealth()
        {
            return _health;
        }
    }
}