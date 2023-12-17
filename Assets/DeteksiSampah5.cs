using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class DeteksiSampah5 : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    void start()
    {
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;

        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag.Equals(nameTag))
        {
            Data.scoreLevel5 += 20;
            // if (Data.scoreLevel4 >= 60)
            // {
            //     SceneManager.LoadSceneAsync(8);
            //     Data.scoreLevel4 = 0;
            // }
            textScore.text = Data.scoreLevel5.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {
            Data.scoreLevel5 -= 5;
            // SceneManager.LoadSceneAsync(5);
            textScore.text = Data.scoreLevel5.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
    }

    void Update()
    {

    }
}
