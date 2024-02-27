using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Su : MonoBehaviour
{
    public Fred Fred;
    public GameObject sign;
    private bool canFall;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player") && canFall)
        {
            Fred.fall = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == sign)
        {
            canFall = true;
        }
    }
}

