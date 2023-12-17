using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;



public class TimeAja3 : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] float remainingTime;
    void Start()
    {
        Data.scoreLevel3 = 0;
    }

    void Update()
    {
        if (remainingTime > 0 && Data.scoreLevel3 < 50)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (Data.scoreLevel3 >= 50)
        {
            SceneManager.LoadSceneAsync(16);

        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            SceneManager.LoadSceneAsync(15);
        }
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = seconds.ToString("");
    }
}
