using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IntroduceSpecialCase;

namespace IntroduceSpecialCase_Before
{
    public class Usage
    {
        private Player _player;

        public void Initialize(Player player)
        {
            _player = player;
        }

        public void DisplayScore()
        {
            int score = 0;
            if (_player != null)
            {
                score = _player.CalculateScore();
                // do something with score
            }
        }

        public void DisplayName()
        {
            string name = "No Player";
            if (_player != null)
            {
                name = _player.GetName();
                // do something with name
            }
        }
    }
}

namespace IntroduceSpecialCase_After
{
    public class NullPlayer : Player
    {
        public NullPlayer() : base("No Player", 0)
        {
        }
    }

    public class Usage
    {
        private Player _player;

        public void Initialize(Player player)
        {
            _player = player ?? new NullPlayer();
        }

        public void DisplayScore()
        {
            int score = _player.CalculateScore();
            // do something with score
        }

        public void DisplayName()
        {
            string name = _player.GetName();
            // do something with name
        }
    }
}