using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rb;
    public float movespeed;

    Vector2 PlayerInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }
    void FixedUpdate()
    {
        Move();
    }
    void ProcessInput()
    {
       PlayerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(PlayerInput.x * movespeed, PlayerInput.y * movespeed);
    }
}
