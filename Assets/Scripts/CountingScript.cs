using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingScript : MonoBehaviour
{
    public float countdownMax = 3.0f;
    public float countdownText = 3.0f;
    public float oldCountdownText = 5.0f;
    public float countdown = 3.0f;
    public Text countdownTimerText;
    public GameObject countdownTimer;
    public GameObject cameraAudio;
    public CountdownScript countdownController;
    public IngameSound ingameSound;
    AudioSource audioSource;
    public AudioClip audioClip;
    private bool playedGo = false;
    
    void Start()
    {
        countdown = countdownMax;
        audioSource = cameraAudio.GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioClip);
    }

    void Update()
    {
        CountdownToGame();
    }

    public void CountdownToGame()
    {
        countdown -= Time.deltaTime;
        //Debug.Log(countdown);

        if (countdown > 0)
        {
            countdownText = Mathf.Ceil(countdown);
            if (countdownText != oldCountdownText)
            {
                audioSource.PlayOneShot(audioClip);
            }
            countdownTimerText.text = countdownText.ToString();
            oldCountdownText = countdownText;
        }
        else if (countdown > -1)
        {
            countdownTimerText.text = "GO!";
            if (!playedGo)
            {
                audioSource.PlayOneShot(audioClip);
                playedGo = true;
            }
        }
        else
        {
            countdown = countdownMax;
            countdownController.boolin = true;
            ingameSound.BeginGame();
            countdownTimer.SetActive(false);
            playedGo = false;
        }
    }
}
