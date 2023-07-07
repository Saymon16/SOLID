using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HideDelegate_Before
{
    public class Usage
    {
        public void Fire(Player player)
        {
            player.CurrentWeapon.Fire();
        }
    }

    public class Player
    {
        public Weapon CurrentWeapon { get; set; }
    }

    public class Weapon
    {
        public int Damage { get; set; }

        public void Fire()
        {
            // Firing logic here...
        }
    }
}

namespace HideDelegate_After
{
    public class Usage
    {
        public void Fire(Player player)
        {
            player.FireWeapon();
        }
    }

    public class Player
    {
        public Weapon CurrentWeapon { get; set; }

        public void FireWeapon()
        {
            CurrentWeapon?.Fire();
        }
    }

    public class Weapon
    {
        public int Damage { get; set; }

        public void Fire()
        {
            // Firing logic here...
        }
    }
}