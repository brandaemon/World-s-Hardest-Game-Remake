using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalCoins;
    public int collectedCoins = 0;
    public GameObject[] coins;
    public DeathManager DeathM;
    public int deaths = 0;
    public int level;
    void Start()
    {
        DeathM = GameObject.Find("Death Manager").GetComponent<DeathManager>();
    }
    void Update()
    {
        deaths = DeathM.deaths;
    }

    public void collectCoin()
    {
        collectedCoins++;
    }

    public bool allCoins()
    {
        return totalCoins == collectedCoins;
    }
    public void resetCoins()
    {
        DeathM.addDeath();
        collectedCoins = 0;
        for(int i=0;i<coins.Length;i++)
        {
            coins[i].gameObject.GetComponent<coin>().reset();
        }
    }
}