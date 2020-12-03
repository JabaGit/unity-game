using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 20f;
    public float forcePool = 1000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(forcePool > 0)
        {
            forcePool -= forwardForce;
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }
    }
}
