﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    private float startTime;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string seconds = (60 - (float)t).ToString("f2");

        if (t < 60)
        {
            timerText.text = seconds;
        }
        else
        {
            timerText.text = "0.00";
        }
    }
}