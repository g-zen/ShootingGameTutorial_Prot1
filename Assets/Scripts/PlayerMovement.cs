using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 velocity = new Vector3();

        velocity.x += Input.GetAxis("Horizontal");
        velocity.y += Input.GetAxis("Vertical");

        rb.velocity = velocity * speed * Time.deltaTime;
    }
}
