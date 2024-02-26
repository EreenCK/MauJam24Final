using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    // Start is called before the first frame update
    public string scenename;
    
   public void scenegec()
    {
        SceneManager.LoadScene(scenename);
    }

}
