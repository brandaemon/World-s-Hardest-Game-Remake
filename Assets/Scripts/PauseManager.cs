using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public void MyOnClick()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }
    public void MyOnClick1()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
}