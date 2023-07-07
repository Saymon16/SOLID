using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtractClass;

namespace ExtractClass_Before
{
    public class Player : MonoBehaviour
    {
        // Combat attributes
        public int Health;
        public int Strength;
        public int Defense;

        // Movement attributes
        public float Speed;
        public float JumpHeight;

        public void Attack(Enemy enemy)
        {
            // Attack logic here...
        }

        public void Move(Vector3 direction)
        {
            // Movement logic here...
        }

        public void Jump()
        {
            // Jump logic here...
        }
    }
}

namespace ExtractClass_After
{
    public class PlayerCombat : MonoBehaviour
    {
        public int Health;
        public int Strength;
        public int Defense;

        public void Attack(Enemy enemy)
        {
            // Attack logic here...
        }
    }

    public class PlayerMovement : MonoBehaviour
    {
        public float Speed;
        public float JumpHeight;

        public void Move(Vector3 direction)
        {
            // Movement logic here...
        }

        public void Jump()
        {
            // Jump logic here...
        }
    }
}