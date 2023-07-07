using UnityEngine;

namespace EncapsulateRecord_Before
{
    public struct PlayerData
    {
        public string Name;
        public int Health;
        public Vector3 Position;
    }
}

namespace EncapsulateRecord_After
{
    public class PlayerData
    {
        private string _name;
        private int _health;
        private Vector3 _position;

        public string Name
        {
            get { return _name; }
            set { _name = value; }  // Here you can add checks or transformations if needed
        }

        public int Health
        {
            get { return _health; }
            set { _health = Mathf.Max(0, value); }  // Ensure health never goes below 0
        }

        public Vector3 Position
        {
            get { return _position; }
            set { _position = value; } // Here you can add checks or transformations if needed
        }

        public PlayerData(string name, int health, Vector3 position)
        {
            _name = name;
            _health = health;
            _position = position;
        }
    }
}