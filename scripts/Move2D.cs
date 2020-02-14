using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float moveImput;
    public Rigidbody2D rb;
    private int maxJump = 1;
    private int numJump = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        numJump = maxJump;
    }

    void Update()
    {
        jump();
    
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(numJump == 1)
            {
                rb.velocity = Vector2.up * jumpForce;
                
            }
            numJump -= 1;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        numJump = 1;
    }
}
