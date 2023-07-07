using System;
using UnityEngine;

namespace CombineFunctionsIntoTransform_Before
{
    public class PlayerController : MonoBehaviour
    {
        private Vector3 _playerPosition;

        private void Start()
        {
            _playerPosition = transform.position;
        }

        private void Update()
        {
            MovePlayerForward(1f * Time.deltaTime);
            transform.position = _playerPosition;
        }

        public void MovePlayerForward(float distance)
        {
            _playerPosition += new Vector3(0, 0, distance);
        }

        public void MovePlayerRight(float distance)
        {
            _playerPosition += new Vector3(distance, 0, 0);
        }

        public void MovePlayerUp(float distance)
        {
            _playerPosition += new Vector3(0, distance, 0);
        }

        public void RotatePlayer(float angle, Vector3 axis)
        {
            _playerPosition = Quaternion.AngleAxis(angle, axis) * _playerPosition;
        }
    }
}

namespace CombineFunctionsIntoTransform_After
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerTransform _playerTransform;

        private void Start()
        {
            _playerTransform = new PlayerTransform(transform.position);
        }

        private void Update()
        {
            _playerTransform.MoveForward(1f * Time.deltaTime);
            transform.position = _playerTransform.GetPosition();
        }
    }

    public class PlayerTransform
    {
        private Vector3 _position;

        public PlayerTransform(Vector3 initialPosition)
        {
            _position = initialPosition;
        }

        public void MoveForward(float distance)
        {
            _position += new Vector3(0, 0, distance);
        }

        public void MoveRight(float distance)
        {
            _position += new Vector3(distance, 0, 0);
        }

        public void MoveUp(float distance)
        {
            _position += new Vector3(0, distance, 0);
        }

        public void Rotate(float angle, Vector3 axis)
        {
            _position = Quaternion.AngleAxis(angle, axis) * _position;
        }

        public Vector3 GetPosition()
        {
            return _position;
        }
    }
}