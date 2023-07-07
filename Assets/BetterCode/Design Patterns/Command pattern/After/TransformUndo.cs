using UnityEngine;

namespace CommandPattern_After
{
    public class TransformUndo : MonoBehaviour
    {
        public void Move(Vector3 newPosition)
        {
            CommandManager.Instance.ExecuteCommand(new MoveCommand(transform, newPosition));
        }

        public void Rotate(Quaternion newRotation)
        {
            CommandManager.Instance.ExecuteCommand(new RotateCommand(transform, newRotation));
        }

        public void Undo() => CommandManager.Instance.UndoLastCommand();
    }
}