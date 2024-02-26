using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMission : MonoBehaviour
{
    public string sceneName;
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void StartMissions()
    {
        SceneManager.LoadScene(sceneName);
    }
}
