using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Fred fred;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggerlabndý");
            if (other.gameObject.CompareTag("Player"))
            {
              fred.paint = true;
              fred.Canpaint= true;
                
            }
    }
}
