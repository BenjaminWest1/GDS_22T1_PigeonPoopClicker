using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    // Initialising variables, we need 
    private float maxTime = 10.0f;
    private float countdownTimer = 0.0f;
    private float countdownTimerRounded = 0.0f;

    public Text clockDisplay;
    public CountdownScript countdownScript;

    AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject cameraAudio;

    public bool boolVariable = false;
    public bool countdownActive = false;
    private bool playOnce = true;
    // bool booling = false;

    // Start is called before the first frame update
    void Start()
    {
        countdownTimer = maxTime;
        audioSource = cameraAudio.GetComponent<AudioSource>();
        //booling = countdownScript.GetComponent<CountdownScript>();
        countdownScript.BeginCountdown();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (countdownScript != null)
        {
            boolVariable = countdownScript.boolin;

            if (boolVariable)
            {
                UpdateClock();
                if (playOnce)
                {
                    audioSource.PlayOneShot(audioClip);
                    playOnce = false;
                }
            }
        }
    }

    private void UpdateClock()
    {
        if (countdownTimer > 0)
        {
            countdownTimer -= Time.deltaTime;
            countdownTimerRounded = Mathf.Round(countdownTimer * 1000) / 1000;
            clockDisplay.text = "Time: " + countdownTimerRounded.ToString();
            countdownActive = true;
            //Debug.Log(countdownTimer);
        }
        else
        {
            clockDisplay.text = "Time: 0.000";
            boolVariable = false;
            countdownScript.boolin = boolVariable;
            countdownActive = false;
        }
    }
}
