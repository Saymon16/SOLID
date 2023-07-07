using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SplitVariable_Before
{
    public class GameController : MonoBehaviour
    {
        private const float GRAVITY = 9.8f;
        private float _initialVelocity;
        private float _firingAngle;
        private float _mass = 1.0f;

        public void CalculateTrajectory(float time, float velocityBoost)
        {
            float velocity = _initialVelocity + velocityBoost;

            float velocityX = velocity * Mathf.Cos(_firingAngle);
            float velocityY = velocity * Mathf.Sin(_firingAngle);

            velocity = velocityY - GRAVITY * time;

            float distanceX = velocityX * time;
            float distanceY = ( velocityY * time ) - ( 0.5f * GRAVITY * Mathf.Pow(time, 2) );

            float kineticEnergy = 0.5f * _mass * Mathf.Pow(velocity, 2);
            Debug.Log($"Distance X: {distanceX}, Distance Y: {distanceY}");
            Debug.Log($"Kinetic Energy: {kineticEnergy} joules");
        }
    }
}

namespace SplitVariable_After
{
    public class GameController : MonoBehaviour
    {
        private const float GRAVITY = 9.8f;
        private float _initialVelocity;
        private float _firingAngle;
        private float _mass = 1.0f;

        public void CalculateTrajectory(float time, float velocityBoost)
        {
            float velocity = _initialVelocity + velocityBoost;

            float velocityY = velocity * Mathf.Sin(_firingAngle);
            float velocityX = velocity * Mathf.Cos(_firingAngle);

            float finalVelocityY = velocityY - GRAVITY * time;

            float distanceX = velocityX * time;
            float distanceY = ( velocityY * time ) - ( 0.5f * GRAVITY * Mathf.Pow(time, 2) );

            float kineticEnergy = 0.5f * _mass * Mathf.Pow(finalVelocityY, 2);

            Debug.Log($"Distance X: {distanceX}, Distance Y: {distanceY}");
            Debug.Log($"Kinetic Energy: {kineticEnergy} joules");
        }
    }
}