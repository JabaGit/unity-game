using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMover : MonoBehaviour
{

    public Vector3 startPoint;
    public Vector3 endPoint;
    public float speed = 1f;
    
    void FixedUpdate()
    {
        
    transform.position = Vector3.Lerp(startPoint, endPoint, Mathf.PingPong(Time.time * speed, 1.0f));
        
    }
}
