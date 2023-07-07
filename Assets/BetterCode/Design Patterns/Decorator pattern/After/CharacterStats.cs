using UnityEngine;

namespace DecoratorPattern_After
{
    // This is the abstract 'Component' class
    public abstract class CharacterStats
    {
        // Abstract method that will be implemented in concrete classes and decorators
        public abstract float GetSpeed();
    }
    
    // Concrete 'Component' class used as base value provider
    public class CharacterBaseValues : CharacterStats
    {
        // This method will be overridden by our decorators
        public override float GetSpeed()
        {
            // Base speed value
            return 1f;
        }
    }

    // This is the abstract 'Decorator' class
    public abstract class CharacterStatsDecorator : CharacterStats
    {
        public CharacterStats CharacterStats;
    }

    // This is a concrete 'Decorator' class used
    public class SpeedBoost : CharacterStatsDecorator
    {
        // Constructor for the decorator that assigns the CharacterStats reference
        public SpeedBoost(CharacterStats characterStats)
        {
            CharacterStats = characterStats;
        }

        // Overriding the GetSpeed method to apply the speed boost
        public override float GetSpeed()
        {
            // The speed boost doubles the current speed
            return  CharacterStats.GetSpeed() * 2f;
        }
    }

    // This is a factory class that creates decorators based on a string identifier
    public static class CharacterStatsDecoratorFactory
    {
        public static CharacterStats CreateStatusEffectDecorator(string type, CharacterStats statusEffect)
        {
            // Switch-case structure to determine which decorator to return
            switch (type)
            {
                case "Speed":      return new SpeedBoost(statusEffect);
                default:                return null;
            }
        }
    }
}