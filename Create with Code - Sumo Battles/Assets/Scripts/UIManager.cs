using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject pauseUI;
    public GameObject playUI;
    public GameObject GameOverUI;
    public TextMeshProUGUI roundText;
    public int roundNum = 0;

    void Awake()
    {
        instance = this;
    }

    void Update() 
    {
        roundText.text = "Round " + roundNum;
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(true);
        playUI.SetActive(false);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
        playUI.SetActive(true);
    }

    public void GameOverScreen()
    {
        GameOverUI.SetActive(true);
        pauseUI.SetActive(false);
        playUI.SetActive(false);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
