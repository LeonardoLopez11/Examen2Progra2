using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimiento : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        movement = new Vector3(moveX, 0, moveY).normalized;
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
