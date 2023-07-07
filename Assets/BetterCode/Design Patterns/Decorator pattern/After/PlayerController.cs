using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPattern_After
{
    public class PlayerController : MonoBehaviour
    {
        private CharacterStats _characterStats;
        private List<string> _decorators;

        private void Start()
        {
            // Assign the base values decorator
            _characterStats = new CharacterBaseValues();
            
            //Define decorators to be added
            _decorators = new List<string>() { "Speed" };

            //Attach each special decorators to character
            foreach (var item in _decorators)
            {
                _characterStats = CharacterStatsDecoratorFactory.CreateStatusEffectDecorator(item, _characterStats);
            }

            float speed = _characterStats.GetSpeed();
        }
    }
}