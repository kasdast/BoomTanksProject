using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{
    private Vector2 movementVector;
    public Rigidbody2D rb2d;
    public float maxSpeed = 10;
    public float rotationSpeed = 120;

    private void Awake()
    {
        rb2d = GetComponentInParent<Rigidbody2D>();
    }

    public void Move(Vector2 movementVector)
    {
        this.movementVector = movementVector;
    }

    private void FixedUpdate()
    {
        rb2d.linearVelocity = (Vector2)transform.up * movementVector.y * maxSpeed * Time.fixedDeltaTime;
        rb2d.MoveRotation(transform.rotation * Quaternion.Euler(0, 0, -movementVector.x * rotationSpeed * Time.fixedDeltaTime));
    }
}
