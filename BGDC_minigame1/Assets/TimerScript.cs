using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    public float startTime;
    public float t;
    // Use this for initialization
    void Start()
    {
        startTime = Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        t = Time.deltaTime - startTime;

        string seconds = (60 - (float)t).ToString("f0");

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