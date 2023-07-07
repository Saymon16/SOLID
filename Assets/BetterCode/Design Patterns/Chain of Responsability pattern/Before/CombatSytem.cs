
namespace ChainOfResponsabilityPattern_Before
{
    public class CombatSystem
    {
        public void ApplyCombatEffect(CombatTarget target, CombatEffect effect)
        {
            switch (effect.Type)
            {
                case CombatEffect.EffectType.Damage:
                    target.TakeDamage(effect.Amount);
                    break;
                case CombatEffect.EffectType.Heal:
                    target.Heal(effect.Amount);
                    break;
                case CombatEffect.EffectType.Stun:
                    target.ApplyStun(effect.Duration);
                    break;
            }
        }
    }

    public class CombatEffect
    {
        public enum EffectType
        {
            Damage,
            Heal,
            Stun
        }

        public EffectType Type;
        public float Amount;
        public float Duration;
    }

    public class CombatTarget
    {
        public void TakeDamage(float amount)
        {
        }

        public void Heal(float amount)
        {
        }

        public void ApplyStun(float duration)
        {
        }
    }
}