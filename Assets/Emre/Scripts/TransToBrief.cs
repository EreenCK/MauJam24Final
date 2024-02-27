using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransToBrief : MonoBehaviour
{
    public string sceneName;

    void OnEnable()
    {
        SceneManager.LoadScene(sceneName);
    }
}
