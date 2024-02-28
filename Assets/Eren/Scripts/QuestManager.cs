using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public Fred Fred;
    private bool camKirildi;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Break") && Fred.BrokenGlass == false && !camKirildi)
        {
            Fred.BrokenGlass = true;
            Fred.CreateGlass(gameObject.transform);
            camKirildi = true;
        }
    }
}
