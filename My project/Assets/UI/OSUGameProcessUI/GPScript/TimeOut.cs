using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeOut : MonoBehaviour
{
    // [SerializeField] private float time;
    [SerializeField] private Text timerText;

    private float _timeLeft = 0f;

    public GameObject gameOverUI;

    [SerializeField] private Text FinalScoreText;
    [SerializeField] private Text ScoreText;

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
    }

    public void Start()
    {
        _timeLeft = BaseStatic.timeLever_1;
        StartCoroutine(StartTimer());
    }

    // Update is called once per frame
    private void UpdateTimeText()
    {
        if (_timeLeft < 0) _timeLeft = 0;
        float min = Mathf.FloorToInt(_timeLeft / 60);
        float sec = Mathf.FloorToInt(_timeLeft % 60);

        timerText.text = string.Format("{0:00} : {1:00}", min, sec);
        if(min == 0 && sec == 0)
        {
            gameOverUI.SetActive(true);
            string finalScore = ScoreText.text;
            FinalScoreText.text = "¬аш счЄт: " + finalScore;
        }
    }
}
