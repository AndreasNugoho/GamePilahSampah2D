using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selamat : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
