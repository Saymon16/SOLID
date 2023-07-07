using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplaceConstructorWithFactoryFunction_Before
{
    public class Spawner : MonoBehaviour
    {
        public Enemy SpawnEnemy(Enemy.EnemyType type)
        {
            switch (type)
            {
                case Enemy.EnemyType.Zombie:
                    return new Zombie();
                case Enemy.EnemyType.Vampire:
                    return new Vampire();
                default:
                    throw new Exception("Invalid enemy type");
            }
        }
    }

    public class Enemy
    {
        public enum EnemyType
        {
            Zombie,
            Vampire
        }
    }

    public class Zombie : Enemy
    {
    }

    public class Vampire : Enemy
    {
    }
}

namespace ReplaceConstructorWithFactoryFunction_After
{
    public class Spawner : MonoBehaviour
    {
        public Enemy SpawnEnemy(Enemy.EnemyType type)
        {
            return Enemy.Create(type);
        }
    }

    public class Enemy
    {
        public enum EnemyType
        {
            Zombie,
            Vampire
        }

        private static readonly Dictionary<EnemyType, Func<Enemy>> _factories = new Dictionary<EnemyType, Func<Enemy>>
        {
            { EnemyType.Zombie, () => new Zombie() },
            { EnemyType.Vampire, () => new Vampire() }
        };

        public static Enemy Create(EnemyType type)
        {
            return _factories.TryGetValue(type, out var factory) ? factory() : throw new Exception("Invalid enemy type");
        }
    }

    public class Zombie : Enemy
    {
    }

    public class Vampire : Enemy
    {
    }
}