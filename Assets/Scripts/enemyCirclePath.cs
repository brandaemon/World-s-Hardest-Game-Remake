using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCirclePath : MonoBehaviour
{
    public float speed;
    public float radius;
    public Transform centerPosition;
    public float angle;
    public GameManager manager;
    void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    void Update()
    {
        angle += speed * Time.deltaTime;
        float x = centerPosition.position.x + Mathf.Cos(angle) * radius;
        float y = centerPosition.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector3(x, y, transform.position.z);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
            player.resetPlayer();
            manager.resetCoins();
        }
    }
}
