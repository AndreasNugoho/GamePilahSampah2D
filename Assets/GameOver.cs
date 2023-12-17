using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void BackMateri()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void ToLevelOne()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void ToLevelTwo()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void ToLevelThree()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void ToLevelFour()
    {
        SceneManager.LoadSceneAsync(9);
    }
    public void ToLevelFive()
    {
        SceneManager.LoadSceneAsync(12);
    }
}
