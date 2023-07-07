using UnityEngine;

namespace StateMachinePattern_After
{
    public interface IState
    {
        void Tick();
        void OnEnter();
        void OnExit();
    }

    public class Running : IState
    {
        private float _moveSpeed;
        private PlayerController _playerController;

        public Running(PlayerController playerController, float moveSpeed)
        {
            _moveSpeed = moveSpeed;
            _playerController = playerController;
        }

        public void Tick()
        {
            _playerController.Move(_moveSpeed);
        }

        public void OnEnter()
        {
        }

        public void OnExit()
        {
        }
    }

    public class Jumping : IState
    {
        private float _jumpHeight;
        private PlayerController _playerController;

        public Jumping(PlayerController playerController, float jumpHeight)
        {
            _jumpHeight = jumpHeight;
            _playerController = playerController;
        }

        public void Tick()
        {
        }

        public void OnEnter()
        {
            _playerController.Jump(_jumpHeight);
        }

        public void OnExit()
        {
        }
    }

    public class Idle : IState
    {
        public void Tick()
        {
        }

        public void OnEnter()
        {
        }

        public void OnExit()
        {
        }
    }
}