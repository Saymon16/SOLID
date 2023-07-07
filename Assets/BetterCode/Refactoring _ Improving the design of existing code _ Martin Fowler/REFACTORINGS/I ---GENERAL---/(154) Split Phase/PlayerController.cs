using System;
using UnityEngine;

namespace SplitPhase_Before
{
    public class PlayerController : MonoBehaviour
    {
        private string _playerName;
        private int _health;
        private Vector3 _position;

        public void InitializeFromJson(string json)
        {
            // Parse the JSON
            var playerData = JsonUtility.FromJson<PlayerData>(json);

            // Set the player's properties
            _playerName = playerData.Name;
            _health = playerData.Health;
            _position = new Vector3(playerData.Position.x, playerData.Position.y, playerData.Position.z);
        }

        // Assume a PlayerData class exists
        private class PlayerData
        {
            public string Name;
            public int Health;
            public Vector3 Position;
        }
    }
}

namespace SplitPhase_After
{
    public class PlayerController : MonoBehaviour
    {
        public class Player : MonoBehaviour
        {
            private string _playerName;
            private int _health;
            private Vector3 _position;

            public void InitializeFromJson(string json)
            {
                var playerData = ParseJson(json);
                SetProperties(playerData);
            }

            private PlayerData ParseJson(string json)
            {
                return JsonUtility.FromJson<PlayerData>(json);
            }

            private void SetProperties(PlayerData playerData)
            {
                _playerName = playerData.Name;
                _health = playerData.Health;
                _position = new Vector3(playerData.Position.x, playerData.Position.y, playerData.Position.z);
            }

            private class PlayerData
            {
                public string Name;
                public int Health;
                public Vector3 Position;
            }
        }
    }
}