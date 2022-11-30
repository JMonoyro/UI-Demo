using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    [SerializeField] int add50Score;

    public Text ScoreText;

    public void OnClickButton()
    {
        add50Score += 50;
    }
    private void Update()
    {
        ScoreText.text = add50Score.ToString();
    }
}
