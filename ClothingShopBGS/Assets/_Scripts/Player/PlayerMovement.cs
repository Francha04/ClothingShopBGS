using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Using a script from another project.
// Will not use point and click movement since Stardew Valley is this task's main inspiration.
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    
    float horizontal;
    float vertical;

    [SerializeField] private float runSpeed = 20.0f;

    Vector2 moveInput;

    PlayerDirections currentDirection;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        moveInput = new Vector2(horizontal, vertical).normalized;

        body.velocity = moveInput * runSpeed;

        UpdateDirection();
    }
    public PlayerDirections GetCurrentDirection()
    {
        return currentDirection;
    }
    private void UpdateDirection() 
    {
        float yAbsSpeed = Mathf.Abs(body.velocity.y);
        float xAbsSpeed = Mathf.Abs(body.velocity.x);
        if (yAbsSpeed > xAbsSpeed)
        {
            if (body.velocity.y > 0)
            {
                currentDirection = PlayerDirections.Up;
            }
            else 
            {
                currentDirection = PlayerDirections.Down;
            }
        }
        else if (yAbsSpeed < xAbsSpeed) 
        {
            if (body.velocity.x > 0)
            {
                currentDirection = PlayerDirections.Right;
            }
            else
            {
                currentDirection = PlayerDirections.Left;
            }
        }
    }
}
