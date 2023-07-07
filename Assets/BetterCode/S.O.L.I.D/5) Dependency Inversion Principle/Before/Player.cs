using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DependencyInversionPrinciple_Before
{
    public class Player : MonoBehaviour
    {
        private Sword _sword;
        private Axe _axe;
        private string _equippedWeaponType;

        public void EquipSword(Sword swordToEquip)
        {
            _sword = swordToEquip;
            _equippedWeaponType = "Sword";
        }

        public void EquipAxe(Axe axeToEquip)
        {
            _axe = axeToEquip;
            _equippedWeaponType = "Axe";
        }

        public void Attack()
        {
            switch (_equippedWeaponType)
            {
                case "Sword" :
                    _sword.Swing();
                    break;
                case "Axe" :
                    _axe.Swing();
                    break;
            }
        }
    }
}