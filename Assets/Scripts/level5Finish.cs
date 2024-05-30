using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level5Finish : MonoBehaviour
{
    public GameManager manager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&manager.collectedCoins==manager.totalCoins)
        {
            SceneManager.LoadScene("End_Screen");
        }
    }
}