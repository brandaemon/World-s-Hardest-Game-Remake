using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private Vector2 startingPosition;
    PlayerMovement player;

    void Start()
    {
        GameManager gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        gameManager.totalCoins++;
        startingPosition = transform.position;
        player = GameObject.Find("Square").GetComponent<PlayerMovement>();
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CoinHitbox"))
        {
            GameManager gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
            gameManager.collectCoin();
            Vector2 newPosition = transform.position;
            newPosition.x -= 100;
            transform.position = newPosition;
            player.audioSource.PlayOneShot(player.coinCollectSFX, 1F);
        }
        if (collision.CompareTag("CoinHitbox"))
        {
            
        }
    }
    public void reset()
    {
        transform.position = startingPosition;
    }
}