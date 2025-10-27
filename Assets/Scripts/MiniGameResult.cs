using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MiniGameResult : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Result;
    

    public void ColseResult()
    {
        gameObject.SetActive(false);
    }
    public void PopReslut()
    {
        Result.text = MiniGameManager.Instance.HighScore.ToString();
        gameObject.SetActive(true);
    }
}

