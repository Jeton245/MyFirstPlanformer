using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
   [SerializeField] private GameObject currentTeleport;
    bool noteleport = false ; 
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            if(currentTeleport != null && !noteleport)
            {
                transform.position = currentTeleport.GetComponent<Teleport>().GetDestiontion().position;
                //Destroy(currentTeleport);
                noteleport = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleport"))
        {
            currentTeleport = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleport"))
        {
            if(collision.gameObject == currentTeleport)
            {
                currentTeleport = null;
            }
        }
    }
}
