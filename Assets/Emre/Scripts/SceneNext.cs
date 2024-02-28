using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    // Start is called before the first frame update
    public string scenename;

    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    public void scenegec()
    {
        SceneManager.LoadScene(scenename);
    }

}
