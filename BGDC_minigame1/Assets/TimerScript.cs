using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public Text timerText;
	public float time;
	private bool play;
    // Use this for initialization
    void Start()
    {
        timerText.text = "60";
        time = 60;
        play = false;
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
            }
        }
    }
    public void ClickPlay()
    {
        pauseMenuUI.SetActive(false);
        play = true;
    }
    public void ClickPause()
    {
        pauseMenuUI.SetActive(true);
        play = false;
    }

    public void ClickReset()
    {
        pauseMenuUI.SetActive(false);
        timerText.text = "60";
        time = 60;
        play = false;
    }
}