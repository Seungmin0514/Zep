using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;
    public TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        if(restartText == null)
        {
            Debug.LogError("restart text is null");
        }
        if (scoreText == null)
        {
            Debug.LogError("score text is null");
        }
        restartText.gameObject.SetActive(false);
    }

    public void SetReStart()
    {
        restartText.gameObject.SetActive(true);
    }
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();

    }
    public void UpdateHighScore(int highScore)
    {
        highScoreText.text = highScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
