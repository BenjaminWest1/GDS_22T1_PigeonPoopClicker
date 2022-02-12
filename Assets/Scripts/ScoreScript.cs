using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreDisplay;

    private int score = 0;

    public void UpdateScore(int scoreIncrement)
    {
        score += scoreIncrement;
        scoreDisplay.text = "Score: " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        scoreDisplay.text = "Score: 0";
    }
}
