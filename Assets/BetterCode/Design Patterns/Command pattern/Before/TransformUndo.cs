using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern_Before
{
    public class TransformUndo : MonoBehaviour
    {
        private Stack<Vector3> _previousPositions = new Stack<Vector3>();
        private Stack<Quaternion> _previousRotations = new Stack<Quaternion>();

        public void Move(Vector3 newPosition)
        {
            _previousPositions.Push(transform.position);
            transform.position = newPosition;
        }

        public void Rotate(Quaternion newRotation)
        {
            _previousRotations.Push(transform.rotation);
            transform.rotation = newRotation;
        }

        public void UndoMove()
        {
            if (_previousPositions.Count > 0)
            {
                transform.position = _previousPositions.Pop();
            }
        }

        public void UndoRotate()
        {
            if (_previousRotations.Count > 0)
            {
                transform.rotation = _previousRotations.Pop();
            }
        }
    }
}