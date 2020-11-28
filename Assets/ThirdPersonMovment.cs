﻿using Cinemachine.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class ThirdPersonMovment : MonoBehaviour
{
    //public Rigidbody body;
    public Transform cam;
    public Transform groundCheck;
    public Transform body;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 3f;
    public float maxSpeed = 10f;
    public CharacterController controller;
    

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    
    public bool isGrounded;
    float turnSmoothVelocity;
    public Vector3 moveDir;
    public Vector3 direction;
    public Vector3 bodyVelocity;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Vector3 checkpoint;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log("test");
        checkpoint = body.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //body.AddForce(0, jumpForce, 0);
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            //body.velocity = moveDir * speed * Time.deltaTime;
            
            controller.Move(moveDir * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            body.position = checkpoint;
        }
    }

    void FixedUpdate()
    {
        //Vector3 xzVelocity = new Vector3(body.velocity.x, 0f, body.velocity.z);
        //if (direction.magnitude >= 0.1f && body.velocity.magnitude <= maxSpeed)
        {
            
            //body.AddForce(moveDir * speed * Time.fixedDeltaTime, ForceMode.Impulse);
            
            //body.velocity = moveDir * speed * Time.fixedDeltaTime * 0.1f;
        } /*else if(xzVelocity.magnitude >= 0.1f && direction.magnitude == 0)
        {
            body.AddForce(-body.velocity * speed * Time.fixedDeltaTime * 0.5f, ForceMode.Impulse);
            Debug.Log(xzVelocity);
        }*/
        //if (direction.magnitude >= 0.1f) body.MovePosition(body.position + moveDir * speed * Time.fixedDeltaTime);
    }
    
}
