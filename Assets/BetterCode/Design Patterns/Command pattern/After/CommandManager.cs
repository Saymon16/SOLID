using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern_After
{
    public class CommandManager : MonoBehaviour
    {
        public static CommandManager Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private Stack<IUndoableCommand> commandStack = new Stack<IUndoableCommand>();

        public void ExecuteCommand(IUndoableCommand command)
        {
            command.Execute();
            commandStack.Push(command);
        }

        public void UndoLastCommand()
        {
            if (commandStack.Count > 0)
            {
                var command = commandStack.Pop();
                command.Undo();
            }
        }
    }
}