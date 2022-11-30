using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private Text PauseScoreText;
    [SerializeField] private Text ScoreText;

    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;
    public GameObject pauseHelpUI;
    public GameObject pauseBtnsUI;

    private void Update()
    {
     if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }   
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        pauseHelpUI.SetActive(false);
        pauseBtnsUI.SetActive(true);
}
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        string pauseScore = ScoreText.text;
        PauseScoreText.text = pauseScore;
    }

    // Вставить название сцены с главным меню
    public void LoadMenu()
    {
        Debug.Log("Load");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
