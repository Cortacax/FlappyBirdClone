using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }

    
    void Update()
    {
        
    }

    public void UpdateScore() 
    {
        score++;
        ScoreText.text = score.ToString();
    }

    public void RestartGame() 
    {
        SceneManager.LoadScene(1);
    
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);

    }
    public void MenuLoad()
    {
        SceneManager.LoadScene(0);

    }
}
