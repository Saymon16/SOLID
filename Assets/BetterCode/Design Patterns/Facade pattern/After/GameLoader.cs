using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern_After
{
    public class GameLoader
    {
        private GameLoaderFacade _gameLoaderFacade = new GameLoaderFacade();

        public void LoadGame()
        {
            Debug.Log("Game loading started");

            _gameLoaderFacade.InitializeGame();

            Debug.Log("Game loaded");
        }
    }

    public class UserSettings
    {
        public Vector2Int Resolution;
        public bool FullScreen;
        public float MasterVolume;
        public float MusicVolume;
        public float SFXVolume;
        public Dictionary<string, KeyCode> KeyBindings;

        public void Load()
        {
        }
    }

    public class ScreenSettings
    {
        public void SetResolution(Vector2Int resolution)
        {
        }

        public void SetFullscreen(bool fullScreen)
        {
        }
    }

    public class SoundManager
    {
        public void SetMasterVolume(float resolution)
        {
        }

        public void SetMusicVolume(float resolution)
        {
        }

        public void SetSFXVolume(float resolution)
        {
        }
    }

    public class InputManager
    {
        public void LoadKeyBindings(Dictionary<string, KeyCode> keyBindings)
        {
        }
    }
}