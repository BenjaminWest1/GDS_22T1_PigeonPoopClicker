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

    // Start is called before the first frame update
    void Start()
    {
        countdownTimer = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateClock();
    }

    private void UpdateClock()
    {
        if (countdownTimer > 0)
        {
            countdownTimer -= Time.deltaTime;
            countdownTimerRounded = Mathf.Round(countdownTimer * 1000) / 1000;
            clockDisplay.text = "Time: " + countdownTimer.ToString();
            //Debug.Log(countdownTimer);
        }
        else
        {
            clockDisplay.text = "Time: 0.000";
        }
    }
}
