using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChainOfResponsabilityPattern_After
{
    public abstract class CombatEffectHandler
    {
        public abstract void ApplyEffect(CombatTarget target, CombatEffect effect);
        protected CombatEffectHandler NextHandler;
        public void SetNextHandler(CombatEffectHandler nextHandler) => NextHandler = nextHandler;
    }


    public class DamageEffectHandler : CombatEffectHandler
    {
        public override void ApplyEffect(CombatTarget target, CombatEffect effect)
        {
            if (effect.Type == CombatEffect.EffectType.Damage)
                target.TakeDamage(effect.Amount);
            else
                NextHandler?.ApplyEffect(target, effect);
        }
    }

    public class HealEffectHandler : CombatEffectHandler
    {
        public override void ApplyEffect(CombatTarget target, CombatEffect effect)
        {
            if (effect.Type == CombatEffect.EffectType.Heal)
                target.Heal(effect.Amount);
            else
                NextHandler?.ApplyEffect(target, effect);
        }
    }

    public class StunEffectHandler : CombatEffectHandler
    {
        public override void ApplyEffect(CombatTarget target, CombatEffect effect)
        {
            if (effect.Type == CombatEffect.EffectType.Stun)
                target.ApplyStun(effect.Duration);
            else
                NextHandler?.ApplyEffect(target, effect);
        }
    }

    public class KnockBackEffectHandler : CombatEffectHandler
    {
        public override void ApplyEffect(CombatTarget target, CombatEffect effect)
        {
            if (effect.Type == CombatEffect.EffectType.KnockBack)
                target.ApplyKnockBack(effect.Force);
            else
                NextHandler?.ApplyEffect(target, effect);
        }
    }
}