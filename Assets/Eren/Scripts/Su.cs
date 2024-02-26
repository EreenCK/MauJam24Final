using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Su : MonoBehaviour
{

    public Fred Fred;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Fred.fall = true;
        }
    }
}

