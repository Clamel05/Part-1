using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    float forward;
    float turning;
    public float speed = 30f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        forward = Input.GetAxis("Vertical");
        turning = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(turning * -speed * Time.deltaTime);
        rigidbody.AddForce(forward * -speed * transform.up * Time.deltaTime);


    }
}
