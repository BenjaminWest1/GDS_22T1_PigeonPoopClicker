using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreDisplay;
    AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject cameraAudio;

    private int score = 0;
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
        audioSource.PlayOneShot(audioClip);
    }

    public void ResetScore()
    {
        score = 0;
        scoreDisplay.text = "Score: 0";
    }

    public void HighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            //bool for changing UI
        }
        //set active end game UI, displaying score
    }
}
