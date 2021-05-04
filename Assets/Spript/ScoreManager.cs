using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int timercounter  = 0;
    public static float CountDownTime;
    public Text TextCountDown;
    public static int Score;
 
    void Start()
    {
        CountDownTime = 40.0F;
    }

    // 更新
    void Update()
    {
        Vector3 ball = GameObject.Find("Ball").transform.position;

        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
        CountDownTime -= Time.deltaTime;

        if (CountDownTime <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }

        if (CameraController.c == 1 && timercounter == 0)
        {
            CountDownTime = CountDownTime + 10;
            timercounter = 1;
        }

        if (CameraController.c == 2 && timercounter == 1)
        {
            CountDownTime = CountDownTime + 15;
            timercounter = 2;
        }

        if (CameraController.c == 3 && timercounter == 2)
        {
            CountDownTime = CountDownTime + 10;
            timercounter = 3;
        }

        if (CameraController.c == 4 && timercounter == 3)
        {
            CountDownTime = CountDownTime + 10;
            timercounter = 0;
        }

        int countDownTime = (int)CountDownTime;
        Score = countDownTime;   
    }
}