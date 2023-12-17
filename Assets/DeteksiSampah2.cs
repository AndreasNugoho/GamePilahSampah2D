using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeteksiSampah2 : MonoBehaviour
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
            Data.scoreLevel2 += 15;

            textScore.text = Data.scoreLevel2.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {
            Data.scoreLevel2 -= 5;
            textScore.text = Data.scoreLevel2.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
    }
    void update()
    {

    }

}
