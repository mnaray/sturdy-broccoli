using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Rigidbody2D rb;
    Vector2 movement;

    public SpriteRenderer spriteRenderer;
    private SturdyBroccoli playerControls;

    private void Awake()
    {
        playerControls = new SturdyBroccoli();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        movement = playerControls.Player.Move.ReadValue<Vector2>();

        if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    // Update is called once per tick
    void FixedUpdate()
    {
        // this updates the rigidbody position
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}