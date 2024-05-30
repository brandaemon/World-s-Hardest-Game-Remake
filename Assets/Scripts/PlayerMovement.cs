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
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        startingPos = transform.position;
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transparency();
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
    public void resetPlayer()
    {
        transform.position = startingPos;
    }
    public IEnumerator transparency()
    {
        Color tmp = GetComponent<SpriteRenderer>().color;
        for (float alpha = 1f; alpha >= 0; alpha-=0.1f)
        {
            
        }
        GetComponent<SpriteRenderer>().color = tmp;
    }
}