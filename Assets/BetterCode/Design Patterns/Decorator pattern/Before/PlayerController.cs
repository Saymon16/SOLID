using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern_Before
{
    public class PlayerController : MonoBehaviour
    {
        private CharacterStats _characterStats;

        void Start()
        {
            _characterStats = new CharacterStats();
            
            _characterStats.HasSpeedBoost = true;

            float speed = _characterStats.BaseSpeed *  ( _characterStats.HasSpeedBoost ? _characterStats.SpeedBoostFactor : 1f );
        }
    }
}