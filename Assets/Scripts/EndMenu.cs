using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public ScoreScript scoreScript;
    public Text scoreDisplay;
    public Text highScoreDisplay;

    private int highScore;

    public void EndGame()
    {
        highScore = scoreScript.HighScore();
        scoreDisplay.text = "Score: " + scoreScript.score;
        highScoreDisplay.text = "Highscore: " +  highScore.ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
