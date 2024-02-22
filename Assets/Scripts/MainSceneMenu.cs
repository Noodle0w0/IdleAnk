using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject xButton;
    void Start()
    {
        Time.timeScale = 1f;
        mainPanel.SetActive(false);
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void XButton()
    {
        Time.timeScale = 0f;
        mainPanel.SetActive(true);
        xButton.SetActive(false);
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        mainPanel.SetActive(false);
        xButton.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
