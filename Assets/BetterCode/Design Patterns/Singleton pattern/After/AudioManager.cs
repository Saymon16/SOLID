using UnityEngine;

namespace SingletonPattern_After
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;

        [SerializeField] private AudioClip _soundEffect;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void PlaySoundEffect()
        {
            AudioSource.PlayClipAtPoint(_soundEffect, transform.position);
        }
    }

    public class Usage : MonoBehaviour
    {
        private void Update()
        {
            if (Input.anyKeyDown)
            {
                AudioManager.Instance.PlaySoundEffect();
            }
        }
    }
}