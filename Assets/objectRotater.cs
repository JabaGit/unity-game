using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotater : MonoBehaviour
{
    public Transform body;
    public float rotationSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        body.Rotate(new Vector3(0, rotationSpeed, 0));
    }
}
