using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb; 

    //private Vector2 moveDirection;
    Vector2 moveDirection;

    // remove Start() function

    // Update is called once per frame
    // driven by framerate of game
    // good for processing inputs
    void Update()
    {
        ProcessInputs();
    }

    // gets called set amount of times per update move 
    // physics calculations
    void FixedUpdate()
    {
        Move();
    }

    // check inputs we looked at before in editor
    void ProcessInputs()
    {
        // GetAxis gives val between 0 and 1, Raw is either 0 or 1 
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical"); 

        moveDirection = new Vector2(moveX, moveY).normalized;   // .normalized caps it to 1 (diagonals) 
    }

    void Move() 
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}