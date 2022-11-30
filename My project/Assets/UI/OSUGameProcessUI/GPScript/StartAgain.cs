using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartAgain : MonoBehaviour
{
    [SerializeField] private Text CleanedText;


    public void ClearScore()
    {
        string txt = "0";
        CleanedText.text = txt;
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    //public void LoadMenu()
    //{
        //Debug.Log("Load");
        //Time.timeScale = 1f;
        //SceneManager.LoadScene("Menu");
    //}
}
