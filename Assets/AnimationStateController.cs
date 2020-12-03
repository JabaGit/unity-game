using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool backwardPressed = Input.GetKey("s");
        bool rightPressed = Input.GetKey("d");
        if(forwardPressed || leftPressed || backwardPressed || rightPressed){
            animator.SetBool("IsRunning", true);

        }
        else {
             animator.SetBool("IsRunning", false);
        }
    }
}
