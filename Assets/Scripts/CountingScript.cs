using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingScript : MonoBehaviour
{
    public float countdownMax = 3.0f;
    public float countdownText = 3.0f;
    public float countdown = 0.0f;
    public Text countdownTimerText;
    public GameObject countdownTimer;

    void OnAwake()
    {
        countdown = countdownMax;
    }

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown > 0)
        {
            countdownText = Mathf.Ceil(countdown);
            countdownTimerText.text = countdownText.ToString();
        }
        else if (countdown > -1)
        {
            countdownTimerText.text = "GO!";
        }
        else
        {

            countdownTimer.SetActive(false);
        }
    }
}
