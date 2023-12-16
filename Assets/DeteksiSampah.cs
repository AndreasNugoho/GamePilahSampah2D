using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeteksiSampah : MonoBehaviour
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
            Data.score += 25;
            // if (Data.score >= -5)
            // {
            //     Data.score = 0;
            //     SceneManager.LoadSceneAsync(5);
            // }
            if (Data.score >= 10)
            {
                // SceneManager.LoadSceneAsync(3);
                SceneManager.LoadSceneAsync(6);
                Data.score = 0;

            }
            //Data.score = 0;



            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {
            Data.score -= 5;
            // if (Data.score == -5)
            // {
            //     Data.score = 0;
            //     SceneManager.LoadSceneAsync(5);
            // }
            SceneManager.LoadSceneAsync(5);
            // if (Data.score >= 10)
            // {
            //     Data.score = 0;
            //     SceneManager.LoadSceneAsync(3);
            // }
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
    }
    void update()
    {

    }


}
