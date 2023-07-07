using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern_After
{
    public interface IUndoableCommand
    {
        void Execute();
        void Undo();
    }

    public class MoveCommand : IUndoableCommand
    {
        private Transform _transform;
        private Vector3 _oldPosition;
        private Vector3 _newPosition;

        public MoveCommand(Transform transform, Vector3 newPosition)
        {
            _transform = transform;
            _oldPosition = transform.position;
            _newPosition = newPosition;
        }

        public void Execute() => _transform.position = _newPosition;
        public void Undo() => _transform.position = _oldPosition;
    }

    public class RotateCommand : IUndoableCommand
    {
        private Transform _transform;
        private Quaternion _oldRotation;
        private Quaternion _newRotation;

        public RotateCommand(Transform transform, Quaternion newRotation)
        {
            _transform = transform;
            _oldRotation = transform.rotation;
            _newRotation = newRotation;
        }

        public void Execute() => _transform.rotation = _newRotation;
        public void Undo() => _transform.rotation = _oldRotation;
    }
}