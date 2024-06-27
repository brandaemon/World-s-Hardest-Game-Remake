using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public float speed = 3.0f;
    private Vector2 startingPos;
    public bool alive = true;
    public AudioClip coinCollectSFX;
    public AudioClip deathSFX;
    public AudioSource audioSource;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        startingPos = transform.position;
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        if(alive)
        {
            rigidbody2d.MovePosition(position);
        }
    }
    public void resetPlayer()
    {
        if(alive)
        {
            alive = false;
            StartCoroutine(transparency());
        }
    }
    public IEnumerator transparency()
    {
        for (float alpha = 1f; alpha >= 0f; alpha-=0.01f)
        {
            Color tmp = GetComponent<SpriteRenderer>().color;
            tmp.a = alpha;
            GetComponent<SpriteRenderer>().color = tmp;
            yield return new WaitForSeconds(.01f);
        }
        GameManager manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        transform.position = startingPos;
        alive = true;
        Color temp = GetComponent<SpriteRenderer>().color;
        temp.a = 1f;
        GetComponent<SpriteRenderer>().color = temp;
        manager.resetCoins();
    }
}