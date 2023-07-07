using UnityEngine;
using MoveStatementsToCallers;

namespace MoveStatementsToCallers_Before
{
    public class Player : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip attackSound;

        public void DealDamage(Enemy enemy)
        {
            enemy.Health -= 10;
            audioSource.PlayOneShot(attackSound);
        }
    }
}

namespace MoveStatementsToCallers_After
{
    public class Player : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip attackSound;

        public void DealDamage(Enemy enemy)
        {
            enemy.Health -= 10;
        }

        public void DealDamageWithSound(Enemy enemy)
        {
            DealDamage(enemy);
            audioSource.PlayOneShot(attackSound);
        }
    }
}