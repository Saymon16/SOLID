using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveField_Before
{
    public class Player : MonoBehaviour
    {
        public int damage = 10;
        public Weapon weapon;
    }

    public class Weapon : MonoBehaviour
    {
        public Player player;

        public void Fire()
        {
            // Fire weapon and deal player's damage
            Debug.Log($"Dealt {player.damage} damage.");
        }
    }

}
namespace MoveField_After
{
    public class Player : MonoBehaviour
    {
        public Weapon weapon;
    }

    public class Weapon : MonoBehaviour
    {
        public int damage = 10;

        public void Fire()
        {
            // Fire weapon and deal damage
            Debug.Log($"Dealt {damage} damage.");
        }
    }

}