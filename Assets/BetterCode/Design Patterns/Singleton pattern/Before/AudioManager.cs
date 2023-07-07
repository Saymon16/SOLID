using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonPattern_Before
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioClip _soundEffect;

        public void PlaySoundEffect()
        {
            AudioSource.PlayClipAtPoint(_soundEffect, transform.position);
        }
    }

    public class Usage : MonoBehaviour
    {
        private AudioManager _audioManager;

        private void Awake()
        {
            _audioManager = FindAnyObjectByType<AudioManager>();
        }

        private void Update()
        {
            if (Input.anyKeyDown)
            {
                _audioManager.PlaySoundEffect();
            }
        }
    }
}