using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    Vector2 movement;

    // public Animator animator;

    void Start(){
    }
    // Update is called once per frame
    void Update()
    {
        // lmao cringe
    }

    // Update is called once per tick
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}