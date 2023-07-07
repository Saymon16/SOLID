using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovSubstitutionPrinciple_Before
{
    public class RangedEnemy : Enemy
    {
        public override void Attack()
        {
        }

        public virtual void StayAtDistance()
        {
        }
    }
}