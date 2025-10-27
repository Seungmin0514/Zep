using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameManager : MonoBehaviour
{
    static MiniGameManager miniGameManager;
    private int highScore =0;
    public static MiniGameManager Instance { get { return miniGameManager; } }

    private int currentScore = 0;

    public UIManager uiManager;
    public UIManager UIManager { get { return uiManager; } }

    private void Awake()
    {
        if (Instance == null)
        {
            miniGameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
        Init();
        
    }
    
    private void Init()
    {
       // Debug.Log("¿Œ¥÷");
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        
        //uiManager.UpdateScore(0);
        //uiManager.UpdateHighScore(highScore);

    }
    public void GameOver()
    {
        //Debug.Log("Game Over");
        HighScoreCheck();
        uiManager.SetReStart();
    }
    private void OnMiniGameSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        uiManager = FindObjectOfType<UIManager>();
        uiManager.UpdateScore(0);
        uiManager.UpdateHighScore(highScore);

        SceneManager.sceneLoaded -= OnMiniGameSceneLoaded; 
    }
    

    public void RestartGame()
    {
        currentScore = 0;
        SceneManager.sceneLoaded += OnMiniGameSceneLoaded;
        SceneManager.LoadScene("MiniGameScene");
        
    }
    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
       // Debug.Log("Score: " + currentScore);
    }
    public void HighScoreCheck()
    {
        if (currentScore > highScore)
        {
            highScore = currentScore;

        } 
    }
}
