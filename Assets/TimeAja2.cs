using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;



public class TimeAja2 : MonoBehaviour
{
    [SerializeField] Text timerText;
    [SerializeField] float remainingTime;
    void Start()
    {
        Data.scoreLevel5 = 0;
    }

    void Update()
    {
        if (remainingTime > 0 && Data.scoreLevel5 < 100)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (Data.scoreLevel5 >= 100)
        {
            SceneManager.LoadSceneAsync(14);

        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            SceneManager.LoadSceneAsync(13);
        }
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = seconds.ToString("");
    }
}
