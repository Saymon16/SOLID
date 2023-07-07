using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SlideStatements_Before
{
    public class Player : MonoBehaviour
    {
        private int _health;
        private int _ammo;
        private bool _isAlive;

        public void InitPlayer()
        {
            _isAlive = true;
            _ammo = 100;
            _health = 100;
            Debug.Log($"Player initialized with health: {_health}, ammo: {_ammo}");
        }
    }
}

namespace SlideStatements_After
{
    public class Player : MonoBehaviour
    {
        private int _health;
        private int _ammo;
        private bool _isAlive;

        public void InitPlayer()
        {
            _ammo = 100;
            _health = 100;
            _isAlive = true;
            Debug.Log($"Player initialized with health: {_health}, ammo: {_ammo}");
        }
    }
}