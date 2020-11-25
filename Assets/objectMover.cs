using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMover : MonoBehaviour
{

    public CharacterController controller;
    //public float direction = 1;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        controller.Move(direction);
        direction.x = Mathf.Sin(Time.time) * 0.1f;
    }
}
