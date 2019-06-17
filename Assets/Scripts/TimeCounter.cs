/*
 * Author: Kaja Więckowska
 * 2019
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public Text timerText;
    public float time = 600;

    public GameMaster gameMaster;
    public Valve valve;
    private bool ExtraTimeAlreadyAdded = false;

    void Start()
    {
        StartCoundownTimer();
    }

    void StartCoundownTimer()
    {
        if(timerText != null)
        {
            time = 600;
            timerText.text = "Time Left: 10:00";
            InvokeRepeating("UpdateTimer", 0.0f, 0.01667f);
        }
    }

    void UpdateTimer()
    {
        if (timerText != null)
        {
            if(time >= 0)
            {
                if (time <= 60)
                {
                    timerText.color = Color.yellow;
                }

                if (time <= 10)
                {
                    timerText.color = Color.red;
                }
                time -= Time.deltaTime;
                string minutes = Mathf.Floor(time / 60).ToString("00");
                string seconds = (time % 60).ToString("00");
                timerText.text = minutes + ":" + seconds;

                if(ExtraTimeAlreadyAdded == false)
                {
                    if (valve.PipeIsWon == true)
                    {
                        time += 300;
                        ExtraTimeAlreadyAdded = true;
                    }
                }
            }
            else
            {
                timerText.text = "00:00";
                gameMaster.ShowGameOver();
            }
        }
    }
}
