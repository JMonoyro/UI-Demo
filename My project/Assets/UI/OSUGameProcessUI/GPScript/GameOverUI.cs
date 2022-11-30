using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text finalText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        finalText.text = "¬аш счЄт: " + score;
    }
}
