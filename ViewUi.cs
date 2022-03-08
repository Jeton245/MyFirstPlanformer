using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewUi : MonoBehaviour
{
    [SerializeField] private GameObject God;
    public GameObject Gods;


    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (God != null)
            {
                Gods.SetActive(true);
                
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TableGod"))
        {
            God = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == God)
        {
            God = null;
        }
    }
}
