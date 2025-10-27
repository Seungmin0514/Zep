using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Vector3 lastPlayerPosition;


   
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
    }

    public void LoadPlayerTransform(Transform transform)
    {
        if (lastPlayerPosition != null)
        {
            transform.position = lastPlayerPosition;
        }
    }
    public void SavePlayerTransform()
    {
        lastPlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        
    }

    public void LoadMainScene()
    {
        
        SceneManager.LoadScene("Main");
    }
    
    
}
