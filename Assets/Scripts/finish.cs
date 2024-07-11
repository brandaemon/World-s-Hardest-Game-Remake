using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public GameManager manager;
    public DeathManager deathManager;
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
            deathManager = GameObject.Find("Death Manager").GetComponent<DeathManager>();
            deathManager.finishSFX();
            print(deathManager);
            SceneManager.LoadScene("Level_"+(manager.level+1).ToString());
        }
    }
}