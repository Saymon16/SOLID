using ReplaceTempWithQuery;

namespace ReplaceTempWithQuery_Before
{
    public class Player
    {
        public int Strength;
        public int WeaponDamage;

        public void Attack(Enemy enemy)
        {
            int damage = Strength * WeaponDamage;
            enemy.TakeDamage(damage);
        }
    }
}

namespace ReplaceTempWithQuery_After
{
    public class Player
    {
        public int Strength;
        public int WeaponDamage;

        public void Attack(Enemy enemy)
        {
            enemy.TakeDamage(CalculateDamage());
        }

        private int CalculateDamage()
        {
            return Strength * WeaponDamage;
        }
    }
}