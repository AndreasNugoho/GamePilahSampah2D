using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selamat2 : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
