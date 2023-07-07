using UnityEngine;

namespace StateMachinePattern_Before
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _jumpHeight;
        [SerializeField] private float _moveSpeed;

        enum State
        {
            Idle,
            Running,
            Jumping,
        }

        private State _state = State.Idle;

        public bool IsGrounded;

        void Update()
        {
            switch (_state)
            {
                case State.Idle:
                    HandleIdle();
                    break;
                case State.Running:
                    HandleRunning();
                    break;
                case State.Jumping:
                    HandleJumping();
                    break;
            }
        }

        void HandleIdle()
        {
            if (Input.GetKey(KeyCode.Space))
                _state = State.Jumping;
            if (Input.GetKey(KeyCode.Z))
                _state = State.Running;
        }

        void HandleRunning()
        {
            Move(_moveSpeed);
            if (!Input.anyKey)
                _state = State.Idle;
        }

        void HandleJumping()
        {
            if (IsGrounded)
            {
                Jump(_jumpHeight);
                _state = State.Idle;
            }
        }

        public void Jump(float jumpHeight)
        {
        }

        public void Move(float moveSpeed)
        {
        }
    }
}