using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject SettingUI;
    public GameObject InGameUI;
    public GameObject PauseMenuUI;
    public GameObject GameOverUI;

    //Main Menu
    public void MM_ClickPlay()
    {
        MainMenuUI.SetActive(false);
        InGameUI.SetActive(true);
    }
    public void MM_ClickSetting()
    {
        SettingUI.SetActive(true);
    }
    public void MM_ClickExit()
    {
        Application.Quit();
    }
    //Setting
    public void S_ClickBack()
    {
        SettingUI.SetActive(false);
    }
    //In Game
    public void IG_ClickPause()
    {
        PauseMenuUI.SetActive(true);
    }
    //Pause Menu
    public void PM_ClickPlay()
    {
        PauseMenuUI.SetActive(false);
    }
    public void PM_ClickRestart()
    {
        PauseMenuUI.SetActive(false);
    }
    public void PM_ClickEnd()
    {
        PauseMenuUI.SetActive(false);
        InGameUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
    //Game Over
    public void GO_ClickBack()
    {
        InGameUI.SetActive(false);
        GameOverUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
}