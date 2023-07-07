using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceFunctionWithCommand_Before
{
    public class Player
    {
        public void Jump()
        {
            // Implementation of the Jump function
        }
    }
}

namespace ReplaceFunctionWithCommand_After
{
    public interface ICommand
    {
        void Execute();
    }

    public class JumpCommand : ICommand
    {
        private Player _player;

        public JumpCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Jump();
        }
    }

    public class Game
    {
        public void OnJumpKeyPressed(Player player)
        {
            ICommand jumpCommand = new JumpCommand(player);
            jumpCommand.Execute();
        }
    }

    public class Player
    {
        public void Jump()
        {
            // Implementation of the Jump function
        }
    }
}