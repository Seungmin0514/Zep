using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBZone : MonoBehaviour
{

    [SerializeField] GameObject FBstartUI;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision != null)
        {
            if (collision.CompareTag("Player"))
            {
                FBstartUI.SetActive(true);
                
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.CompareTag("Player"))
            {
                FBstartUI.SetActive(false);
            }
        }
    }
}
