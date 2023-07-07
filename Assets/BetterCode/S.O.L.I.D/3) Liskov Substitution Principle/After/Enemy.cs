using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LiskovSubstitutionPrinciple_After
{
    public class Enemy
    {
        public virtual void Attack()
        {
        }

        public virtual void StayAtDistance()
        {
        }

        public virtual void ActiveCamouflage()
        {
        }
    }
}