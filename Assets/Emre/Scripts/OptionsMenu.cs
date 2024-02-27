using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject optionsMenuUI;

    public void SetInverseMouse(bool invMouse)
    {

    }

    public void SetVolume(float volume)
    {
        
    }

    public void SetMouseX(float mouseX)
    {

    }
    public void SetMouseY(float mouseY)
    {

    }

    public void doExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("OpeningScene");
    }

    public void OptionsOn()
    {
        startMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
    }
}
