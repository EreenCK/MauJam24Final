using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeObject : MonoBehaviour
{
    public float collisionMultp;
    public AudioSource boxExplodeSFX;
    private ButterflyMovement butterflyMovementSc;
    public bool didExploded = false;
    private GameObject childObj;
    public GameObject kapat;
    public GameObject PatlayanYol;
    public GameObject PatlayanKopru;
    

    void Update()
    {
        //hitObject = butterflyMovementSc.shootedObject;
        if (didExploded && gameObject == PatlayanYol)
        {
            kapat.SetActive(false);
        }
        if (didExploded && gameObject == PatlayanKopru)
        {
            kapat.SetActive(false);
        }
    }


    public void Explode(GameObject player)
    {
        butterflyMovementSc = player.GetComponent<ButterflyMovement>();

        if(!didExploded)
        {
            Debug.Log("Explode object");

            boxExplodeSFX.PlayOneShot(boxExplodeSFX.clip);

            Destroy(GetComponent<Rigidbody>());
            Destroy(GetComponent<Collider>());
            
            foreach (var childCollider in gameObject.GetComponentsInChildren<MeshCollider>())
            {
                childObj = childCollider.gameObject;
                if(childObj != gameObject)
                {
                    childObj.AddComponent<Rigidbody>();
                    childObj.GetComponent<Rigidbody>().isKinematic = false;

                    childObj.GetComponent<Rigidbody>().AddExplosionForce(collisionMultp, butterflyMovementSc.hit.point, 2);
                }
            }

            didExploded = true;
        }
    }
}
