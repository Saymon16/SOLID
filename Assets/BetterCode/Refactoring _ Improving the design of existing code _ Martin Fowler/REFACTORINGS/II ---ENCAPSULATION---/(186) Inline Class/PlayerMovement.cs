using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InlineClass_Before
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed;

        public void Move(Vector3 direction)
        {
            // Movement logic here...
        }
    }

    public class PlayerJump : MonoBehaviour
    {
        public float jumpHeight;

        public void Jump()
        {
            // Jump logic here...
        }
    }
}

namespace InlineClass_After
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed;
        public float jumpHeight;

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