using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceCommandWithFunction_Before
{
    public interface ICommand
    {
        void Execute();
    }

    public class ChangePositionCommand : ICommand
    {
        private Character _character;
        private Vector3 _newPosition;

        public ChangePositionCommand(Character character, Vector3 newPosition)
        {
            _character = character;
            _newPosition = newPosition;
        }

        public void Execute()
        {
            _character.ChangePosition(_newPosition);
        }
    }

    public class Character
    {
        public void ChangePosition(Vector3 newPosition)
        {
            // Logic to change the position of the character.
        }
    }

    public class Game
    {
        public void UpdateCharacterPosition(Character character, Vector3 newPosition)
        {
            ICommand changePositionCommand = new ChangePositionCommand(character, newPosition);
            changePositionCommand.Execute();
        }
    }
}

namespace ReplaceCommandWithFunction_After
{
    public class Character
    {
        public void ChangePosition(Vector3 newPosition)
        {
            // Logic to change the position of the character.
        }
    }

    public class Game
    {
        public void UpdateCharacterPosition(Character character, Vector3 newPosition)
        {
            character.ChangePosition(newPosition);
        }
    }
}