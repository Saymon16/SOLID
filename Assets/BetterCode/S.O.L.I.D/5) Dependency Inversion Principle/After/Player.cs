using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversionPrinciple_After
{
    public class Player : MonoBehaviour
    {
        private IWeapon _weapon;

        public void Equip (IWeapon weaponToEquip)
        {
            _weapon = weaponToEquip;
        }

        public void Attack()
        {
            _weapon.Swing();
        }
    }
}