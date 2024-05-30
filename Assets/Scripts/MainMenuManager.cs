using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public DeathManager deathManager;
    public void MyOnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level_1");
    }
    public void MyOnClick1()
    {
        Destroy(GameObject.Find("Death Manager"));
        SceneManager.LoadScene("Main_Menu");
    }
}