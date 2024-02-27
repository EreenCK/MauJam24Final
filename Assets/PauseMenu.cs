using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private string MainMenuSceneName;

    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;

    public static bool GameIsPaused = false;



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused) 
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(MainMenuSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting...");
    }

    public void OptionsOn()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
    }

    //public void OptionsOff()
    //{
    //    pauseMenuUI.SetActive(true);
    //    optionsMenuUI.SetActive(false);
    //}
}
