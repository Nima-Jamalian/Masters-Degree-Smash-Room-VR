using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int countDownStartVlaue = 120;
    public Text timerUI;
    public GameObject gameOver1;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartVlaue > 0)
        {
            Debug.Log("counting down");
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartVlaue);
            timerUI.text = "" + spanTime.Minutes + ":" + spanTime.Seconds;
            countDownStartVlaue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "0";
            gameOver1.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}