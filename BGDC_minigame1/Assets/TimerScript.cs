using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public GameObject GameOverUI;
    public Text timerText;
	public float time;
	private bool play;
    // Use this for initialization
    void Start()
    {
        timerText.text = "60";
        time = 60;
        play = true;
    }
    // Update is called once per frame
    void Update()
    {
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
                GameOverUI.SetActive(true);
            }
        }
    }
    public void ClickPlay()
    {
        play = true;
    }
    public void ClickPause()
    {
        play = false;
    }
    public void ClickReset()
    {
        timerText.text = "60";
        time = 60;
        play = true;
    }
    public void ClickEnd()
    {
        timerText.text = "60";
        time = 60;
        play = false;
    }
    public void ClickDebug()
    {
        time = 0;
    }
}