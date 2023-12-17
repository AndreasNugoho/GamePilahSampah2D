using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;



public class TimeAja4 : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] float remainingTime;
    void Start()
    {
        Data.scoreLevel2 = 0;
    }

    void Update()
    {
        if (remainingTime > 0 && Data.scoreLevel2 < 40)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (Data.scoreLevel2 >= 40)
        {
            SceneManager.LoadSceneAsync(18);
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            SceneManager.LoadSceneAsync(17);
        }
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = seconds.ToString("");
    }
}
