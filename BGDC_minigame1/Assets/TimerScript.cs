using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    public float startTime;
    public float t;
	float time;
	bool play;
    // Use this for initialization
    void Start()
    {

        timerText.text = "60";
        time = 60;
        play = false;
		startTime = Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        t = Time.deltaTime - startTime;
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
        time = 60;
        play = false;
    }
}