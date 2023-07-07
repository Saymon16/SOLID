using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoveFunction_Before
{
    public class Player : MonoBehaviour
    {
        public Vector3 respawnPoint;

        public void RespawnPlayer()
        {
            transform.position = respawnPoint;
        }
    }

    public class GameController : MonoBehaviour
    {
        public Player player;

        public void SomeGameEvent()
        {
            // Some game event occurs that necessitates respawning the player
            player.RespawnPlayer();
        }
    }
}

namespace MoveFunction_After
{
    public class Player : MonoBehaviour
    {
        public Vector3 respawnPoint;
    }

    public class GameController : MonoBehaviour
    {
        public Player player;

        public void SomeGameEvent()
        {
            // Some game event occurs that necessitates respawning the player
            RespawnPlayer();
        }

        public void RespawnPlayer()
        {
            player.transform.position = player.respawnPoint;
        }
    }
}