using UnityEngine;
using ExtractFunction;

namespace ExtractFunction_Before
{
    public class PlayerController : MonoBehaviour
    {
        private int health = 100;
        private int attackPower = 50;

        public void AttackEnemy(EnemyController enemy)
        {
            // Calculate damage
            int damage = attackPower * 2;

            // Apply damage
            enemy.TakeDamage(damage);

            // Update player health
            health -= enemy.GetDamage();
            if (health < 0) health = 0;
        }
    }
}

namespace ExtractFunction_After
{
    public class PlayerController : MonoBehaviour
    {
        private int health = 100;
        private int attackPower = 50;

        public void AttackEnemy(EnemyController enemy)
        {
            int damage = CalculateDamage();
            ApplyDamageToEnemy(enemy, damage);
            UpdatePlayerHealth(enemy);
        }

        private int CalculateDamage()
        {
            return attackPower * 2;
        }

        private void ApplyDamageToEnemy(EnemyController enemy, int damage)
        {
            enemy.TakeDamage(damage);
        }

        private void UpdatePlayerHealth(EnemyController enemy)
        {
            health -= enemy.GetDamage();
            if (health < 0) health = 0;
        }
    }
}