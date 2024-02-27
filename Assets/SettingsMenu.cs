using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;

    public void OptionsOff()
    {
        pauseMenuUI.SetActive(true);
        optionsMenuUI.SetActive(false);
    }

    public void SetVolumeMusic(float volume) { }

    public void SetVolumeSFX(float volume) { }

    public void SetMouseX(float x)
    {
        
    }

    public void SetMouseY(float y) { }

    public void SetMouseInverse(bool tick)
    {

    }
}
