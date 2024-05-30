using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private Vector2 startingPosition;
    void Start()
    {
        GameManager gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        gameManager.totalCoins++;
        startingPosition = transform.position;
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.CompareTag("CoinHitbox"))
        {
            GameManager gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
            gameManager.collectCoin();
            Vector2 newPosition = transform.position;
            newPosition.x -= 100;
            transform.position = newPosition;
        }
    }
    public void reset()
    {
        transform.position = startingPosition;
    }
}