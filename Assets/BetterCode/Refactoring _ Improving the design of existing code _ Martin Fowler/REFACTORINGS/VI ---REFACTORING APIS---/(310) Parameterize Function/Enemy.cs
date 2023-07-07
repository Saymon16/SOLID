namespace ParameterizeFunction_Before
{
    public class Enemy
    {
        public int Health;

        public void Take10Damage()
        {
            Health -= 10;
        }
    }
}

namespace ParameterizeFunction_After
{
    public class Enemy
    {
        public int Health;

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}