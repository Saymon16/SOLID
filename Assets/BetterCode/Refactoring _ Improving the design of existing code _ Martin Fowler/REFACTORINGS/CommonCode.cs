using System;
using System.Collections.Generic;
using UnityEngine;

namespace ExtractFunction
{
    public class EnemyController
    {
        public void TakeDamage(int damage)
        {
        }

        public int GetDamage() => 1;
    }
}

namespace ReplaceTempWithQuery
{
    public class Enemy
    {
        public void TakeDamage(int damage)
        {
        }
    }
}

namespace ExtractClass
{
    public class Enemy
    {
        public void TakeDamage(int damage)
        {
        }
    }
}

namespace SubstituteAlgorithm
{
    public class Enemy
    {
        public void TakeDamage(int damage)
        {
        }

        public Transform Transform;
    }
}

namespace MoveStatementsToCallers
{
    public class Enemy
    {
        public int Health;
    }
}

namespace ReplaceInlineCodeWithFunctionCall
{
    public class Player
    {
        public int Level;
    }
}

namespace SplitLoop
{
    public class Enemy
    {
        public int Health;
        public int Ammo;
    }
}

namespace ReplaceLoopWithPipeline
{
    public class Enemy
    {
        public bool IsDefeated;
        public int ScoreValue;
    }
}

namespace RemoveDeadCode
{
    public class Enemy
    {
        public static List<Enemy> ActiveEnemies;
        public int ScoreValue;

        public void InitEnemy()
        {
            ActiveEnemies.Add(this);
        }

        public void KillEnemy()
        {
            ActiveEnemies.Remove(this);
            OnDeath?.Invoke();
        }

        public event Action OnDeath;
    }

    public class Player
    {
        public int PlayerHealth;
        public int PlayerAmmo;

        public void InitPlayer()
        {
            PlayerHealth = 10;
            PlayerAmmo = 100;
        }
    }
}

namespace ChangeValueToReference_Before
{
    public class Player
    {
        public Level CurrentLevel { get; private set; }

        public Player(Level level)
        {
            CurrentLevel = level;
        }

        // other properties and methods...
    }
}

namespace ChangeValueToReference_After
{
    public class Player
    {
        public Level CurrentLevel { get; private set; }

        public Player(Level level)
        {
            CurrentLevel = level;
        }

        // other properties and methods...
    }
}

namespace IntroduceSpecialCase
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; private set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string GetName()
        {
            return Name;
        }

        public int CalculateScore()
        {
            return Score;
        }
    }
}

namespace PreserveWholeObject
{
    public class Weapon
    {
        public int Damage;
        public float CriticalMultiplier;
    }
}

namespace ReplaceParameterWithQuery
{
    public class Weapon
    {
        public int Damage;

        public Weapon(int damage)
        {
            Damage = damage;
        }
    }

    public class Player
    {
        public int Health;
    }
}

namespace ReplaceQueryWithParameter
{
    public class Weapon
    {
        private int _damage;

        public Weapon(int damage)
        {
            _damage = damage;
        }

        public int GetDamage()
        {
            return _damage;
        }
    }

    public class Enemy
    {
        public void TakeDamage(int damage)
        {
        }
    }
}