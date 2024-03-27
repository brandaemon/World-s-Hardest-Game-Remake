using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed =2f;
    private int currentWaypointIndex=0;
    public GameManager manager;
    void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    void Update()
    {
        MoveEnemy();
    }
    void MoveEnemy()
    {
        if (waypoints.Length == 0)
        {
            Debug.LogError("No waypoints assigned!");
            return;
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex>=waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement player=collision.gameObject.GetComponent<PlayerMovement>();
            player.resetPlayer();
            manager.resetCoins();
        }
    }
}
