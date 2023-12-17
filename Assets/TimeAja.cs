using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;



public class TimeAja : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] float remainingTime;
    void Start()
    {
        Data.scoreLevel4 = 0;
    }

    void Update()
    {
        if (remainingTime > 0 && Data.scoreLevel4 < 70)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (Data.scoreLevel4 >= 70)
        {
            SceneManager.LoadSceneAsync(11);

        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            SceneManager.LoadSceneAsync(10);
        }
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = seconds.ToString("");
    }
}
