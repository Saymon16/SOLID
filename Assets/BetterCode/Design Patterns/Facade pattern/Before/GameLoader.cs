using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern_Before
{
    public class GameLoader
    {
        public void LoadGame()
        {
            Debug.Log("Game loading started");

            UserSettings userSettings = new UserSettings();
            userSettings.Load();

            ScreenSettings screenSettings = new ScreenSettings();
            screenSettings.SetResolution(userSettings.Resolution);
            screenSettings.SetFullscreen(userSettings.FullScreen);

            SoundManager soundManager = new SoundManager();
            soundManager.SetMasterVolume(userSettings.MasterVolume);
            soundManager.SetMusicVolume(userSettings.MusicVolume);
            soundManager.SetSFXVolume(userSettings.SFXVolume);

            InputManager inputManager = new InputManager();
            inputManager.LoadKeyBindings(userSettings.KeyBindings);

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