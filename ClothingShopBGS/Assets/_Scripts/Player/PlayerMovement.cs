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

    public float runSpeed = 20.0f;

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
        Vector2 input = new Vector2(horizontal, vertical);

        body.velocity = input.normalized * runSpeed;
    }
}
