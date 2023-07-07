using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FacadePattern_After
{
    public class GameLoaderFacade
    {
        UserSettings userSettings = new UserSettings();
        ScreenSettings screenSettings = new ScreenSettings();
        SoundManager soundManager = new SoundManager();
        InputManager inputManager = new InputManager();

        public void InitializeGame()
        {
            userSettings.Load();

            screenSettings.SetResolution(userSettings.Resolution);
            screenSettings.SetFullscreen(userSettings.FullScreen);

            soundManager.SetMasterVolume(userSettings.MasterVolume);
            soundManager.SetMusicVolume(userSettings.MusicVolume);
            soundManager.SetSFXVolume(userSettings.SFXVolume);

            inputManager.LoadKeyBindings(userSettings.KeyBindings);
        }
    }
}