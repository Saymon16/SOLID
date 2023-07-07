using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachinePattern_After
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _jumpHeight;
        [SerializeField] private float _moveSpeed;

        public bool IsGrounded;

        private StateMachine _stateMachine;

        private void Awake()
        {
            _stateMachine = new StateMachine();

            var idle = new Idle();
            var running = new Running(this, _moveSpeed);
            var jumping = new Jumping(this, _jumpHeight);

            _stateMachine.AddTransition(idle, jumping, () => Input.GetKey(KeyCode.Space) );
            _stateMachine.AddTransition(idle, running, () => Input.GetKey(KeyCode.Z) );
            _stateMachine.AddTransition(running, idle, () => !Input.anyKey);
            _stateMachine.AddTransition(jumping, idle, () => IsGrounded);

            _stateMachine.SetState(idle);
        }

        private void Update()
        {
            _stateMachine.Tick();
        }

        public void Jump(float jumpHeight)
        {
        }

        public void Move(float moveSpeed)
        {
        }
    }
}