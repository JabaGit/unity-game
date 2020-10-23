using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovment : MonoBehaviour
{
    public Rigidbody body;
    public Transform cam;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpForce = 3f;
    public float maxSpeed = 10f;
    

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;

    public float gravity = -9.81f;
    
    Vector3 velocity;
    bool isGrounded;
    float turnSmoothVelocity;
    Vector3 moveDir;
    Vector3 direction;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            body.AddForce(0, jumpForce, 0);
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
            
            //controller.Move(moveDir * speed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        if (direction.magnitude >= 0.1f && body.velocity.magnitude <= maxSpeed)
        {

            body.AddForce(moveDir * speed * Time.fixedDeltaTime);
            Debug.Log(body.velocity);
        }
        //if (direction.magnitude >= 0.1f) body.MovePosition(body.position + moveDir * speed * Time.fixedDeltaTime);
    }
}
