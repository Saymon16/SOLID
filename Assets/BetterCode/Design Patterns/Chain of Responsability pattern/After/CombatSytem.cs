using UnityEngine;

namespace ChainOfResponsabilityPattern_After
{
    public class CombatSystem
    {
        private  DamageEffectHandler _handlerFirst = new DamageEffectHandler();
        private  HealEffectHandler _handler2 = new HealEffectHandler();
        private  StunEffectHandler _handler3 = new StunEffectHandler();
        private  KnockBackEffectHandler _handler4 = new KnockBackEffectHandler();

        public CombatSystem()
        {
            _handlerFirst.SetNextHandler(_handler2);
            _handler2.SetNextHandler(_handler3);
            _handler3.SetNextHandler(_handler4);
        }

        public void ApplyCombatEffect(CombatTarget target, CombatEffect effect)
        {
            _handlerFirst.ApplyEffect(target, effect);
        }
    }

    public class CombatEffect
    {
        public enum EffectType
        {
            Damage,
            Heal,
            Stun,
            KnockBack
        }

        public EffectType Type;
        public float Amount;
        public float Duration;
        public float Force;
    }

    public class CombatTarget
    {
        public float Health;
        public Rigidbody Rigidbody;
        public bool CanMove;

        public void TakeDamage(float amount)
        {
            Health -= amount;
        }

        public void Heal(float amount)
        {
            Health  += amount;
        }

        public void ApplyStun(float duration)
        {
            CanMove = false;
            //Wait for duration
            CanMove = true;
        }

        public void ApplyKnockBack(float force)
        {
            Rigidbody.AddForce(Vector3.up * force);
        }
    }
}