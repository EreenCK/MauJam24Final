using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public Fred Fred;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Break") && Fred.BrokenGlass == false)
        {
            Fred.BrokenGlass = true;
            Fred.CreateGlass(gameObject.transform);
        }
    }
}
