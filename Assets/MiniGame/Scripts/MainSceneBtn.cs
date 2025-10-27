using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneBtn : MonoBehaviour
{
    
    public void MainSceneLoad()
    {
        GameManager.Instance.LoadMainScene();
    }
}
