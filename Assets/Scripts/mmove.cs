using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mmove : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {

        moveInput = Input.GetAxis("Horizontal2");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }
}