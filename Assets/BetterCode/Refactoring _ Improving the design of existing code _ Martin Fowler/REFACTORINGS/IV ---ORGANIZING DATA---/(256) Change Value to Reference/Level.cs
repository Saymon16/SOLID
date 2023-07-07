using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChangeValueToReference_Before
{
    public class Usage
    {
        public void CreatePlayersAndAssignLevels()
        {
            Player player1 = new Player(new Level("Level1"));
            Player player2 = new Player(new Level("Level1"));  // Different instances, same level
        }
    }

    public class Level
    {
        public string Name { get; }

        public Level(string name)
        {
            Name = name;
        }

        // other properties and methods...
    }
}

namespace ChangeValueToReference_After
{
    public class Usage
    {
        public void CreatePlayersAndAssignLevels()
        {
            Player player1 = new Player(Level.GetLevel("Level1"));
            Player player2 = new Player(Level.GetLevel("Level1"));  // Same instance, same level
        }
    }

    public class Level
    {
        public string Name { get; }

        private Level(string name)  // Constructor is now private
        {
            Name = name;
        }

        // Factory method to create/retrieve instances
        private static Dictionary<string, Level> levelInstances = new Dictionary<string, Level>();

        public static Level GetLevel(string name)
        {
            if (!levelInstances.ContainsKey(name))
            {
                levelInstances[name] = new Level(name);
            }

            return levelInstances[name];
        }

        // other properties and methods...
    }
}