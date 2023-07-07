using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DuplicatedCode_Before
{
    public class Player
    {
        public float Health;
        public float Mana;
        public event Action OnDeath;

        public void ReduceHealth(float amount)
        {
            Health -= amount;
            if (Health < 0)
            {
                Health = 0;
                OnDeath?.Invoke();
                Debug.Log("Player health is now zero.");
            }
        }

        public void ReduceMana(float amount)
        {
            Mana -= amount;
            if (Mana < 0)
            {
                Debug.Log("Player mana is now zero.");
                Mana = 0;
            }
        }
    }
}

namespace DuplicatedCode_Step1
{
    //Slide Statements so all functions are in the same order and looks the same
    public class Player
    {
        public float Health;
        public float Mana;
        public event Action OnDeath;

        public void ReduceHealth(float amount)
        {
            Health -= amount;
            if (Health < 0)
            {
                Health = 0;
                Debug.Log("Player health is now zero.");
                OnDeath?.Invoke();
            }
        }

        public void ReduceMana(float amount)
        {
            Mana -= amount;
            if (Mana < 0)
            {
                Mana = 0;
                Debug.Log("Player mana is now zero.");
                //on depletion
            }
        }
    }
}

namespace DuplicatedCode_Step2
{
    //Extract Function from the more complex side and call in all old places
    //Little differences are referenced in the Function definition as a new parameter
    public class Player
    {
        public float Health;
        public float Mana;
        public event Action OnDeath;

        public void ReduceHealth(float amount)
        {
            ReduceAttribute(ref Health, "health", OnDeath,  amount);
        }


        public void ReduceMana(float amount)
        {
            ReduceAttribute(ref Mana, "mana", null,  amount);
        }

        private void ReduceAttribute(ref float attribute, string attributeName, Action onAttributeEqualZero, float amount)
        {
            attribute -= amount;
            if (attribute < 0)
            {
                attribute = 0;
                Debug.Log($"Player {attributeName} is now zero.");
                onAttributeEqualZero?.Invoke();
            }
        }
    }
}