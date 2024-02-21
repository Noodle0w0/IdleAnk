using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject creditsPanel;
    void Start()
    {
        mainPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

        public void BackCredits()
    {
        creditsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
