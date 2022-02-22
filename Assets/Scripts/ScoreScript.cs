using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreDisplay;
    AudioSource audioSource;
    public AudioClip splat;
    public AudioClip funnyHorn;
    public GameObject cameraAudio;

    public int score = 0;
    public static int highScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = cameraAudio.GetComponent<AudioSource>();
    }

    public void UpdateScore(int scoreIncrement)
    {
        score += scoreIncrement;
        scoreDisplay.text = "Score: " + score.ToString();
        audioSource.PlayOneShot(splat);
    }

    public void ResetScore()
    {
        score = 0;
        scoreDisplay.text = "Score: 0";
    }

    public int HighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            audioSource.PlayOneShot(funnyHorn);
        }
        return highScore;
    }
}
