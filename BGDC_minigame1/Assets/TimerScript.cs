using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    float time;
    bool play;
    bool reset;

    // Use this for initialization
    void Start()
    {
        timerText.text = "60";
        time = 60;
        play = false;
        reset = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (reset == true && play == true)
        {
            time = 60;
            reset = false;
        }

        if (play == true)
        {
            time -= Time.deltaTime;

            string seconds = (time).ToString("f0");

            if (time > 0)
            {
                timerText.text = seconds;
            }
            else
            {
                timerText.text = "0";
            }
        }
    }
    public void ClickPlay()
    {
        if (play == true)
        {
            play = false;
        }
        else
        {
            play = true;
        }
    }

    public void ClickReset()
    {
        timerText.text = "60";
        reset = true;
        play = false;
    }
}