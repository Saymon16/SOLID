using UnityEngine;
using ReplaceInlineCodeWithFunctionCall;

namespace ReplaceInlineCodeWithFunctionCall_Before
{
    public class GameController : MonoBehaviour
    {
        public Player Player;

        public void EndGame()
        {
            int scoreMultiplier = 1;
            if (Player.Level >= 5)
            {
                scoreMultiplier = 2;
            }
            else if (Player.Level >= 10)
            {
                scoreMultiplier = 3;
            }

            // Use scoreMultiplier...
        }

        public void AwardBonusPoints()
        {
            int scoreMultiplier = 1;
            if (Player.Level >= 5)
            {
                scoreMultiplier = 2;
            }
            else if (Player.Level >= 10)
            {
                scoreMultiplier = 3;
            }

            // Use scoreMultiplier...
        }
    }
}

namespace ReplaceInlineCodeWithFunctionCall_After
{
    public class GameController : MonoBehaviour
    {
        public Player player;

        public void EndGame()
        {
            int scoreMultiplier = CalculateScoreMultiplier();

            // Use scoreMultiplier...
        }

        public void AwardBonusPoints()
        {
            int scoreMultiplier = CalculateScoreMultiplier();

            // Use scoreMultiplier...
        }

        private int CalculateScoreMultiplier()
        {
            if (player.Level >= 10)
            {
                return 3;
            }
            else if (player.Level >= 5)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}