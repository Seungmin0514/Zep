using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class FBZone : MonoBehaviour
{

    [SerializeField] GameObject FBstartUI;
    [SerializeField] GameObject FBUI;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.CompareTag("Player"))
            {
                FBstartUI.SetActive(true);
                collision.GetComponent<PlayerController>().playerInput.Player.Use.performed += OnUseStarted;


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
                FBUI.SetActive(false);
                collision.GetComponent<PlayerController>().playerInput.Player.Use.performed -= OnUseStarted;
                
            }
        }
    }

    private void OnUseStarted(InputAction.CallbackContext context)
    {
        FBUI.SetActive(!FBUI.activeSelf);
        
            
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&FBUI.activeSelf)
        {
            FindObjectOfType<MiniGameManager>().RestartGame();
        }
    }


}
