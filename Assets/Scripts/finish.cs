using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public GameManager manager;
    void Start()
    {

    }
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&&manager.collectedCoins==manager.totalCoins)
        {
            SceneManager.LoadScene("Level_"+(manager.level+1).ToString());
        }
    }
}