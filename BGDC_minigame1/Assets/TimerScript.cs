using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
<<<<<<< HEAD
    public float startTime;
    public float t;
    // Use this for initialization
    void Start()
    {
        startTime = Time.deltaTime;
=======
    float time;
    bool play;

    // Use this for initialization
    void Start()
    {
        timerText.text = "60";
        time = 60;
        play = false;
>>>>>>> 1d2551596a5cc264c2f8d76a4f054cc9ff920eb9
    }
    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        t = Time.deltaTime - startTime;
=======
        if (play == true)
        {
            time -= Time.deltaTime;
>>>>>>> 1d2551596a5cc264c2f8d76a4f054cc9ff920eb9

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
        time = 60;
        play = false;
    }
}