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
        bool hasWon = Finisher.playerHasWon;
        bool isDead = DeathHandler.playerIsDead || SpearTrapDeathHandler.playerIsDead;
        bool isJumping = ThirdPersonMovment.playerIsJumping;
        bool isJumpingDown = ThirdPersonMovment.playerIsJumpingDown;
        bool isActivated = ActivateSpearTrap.spearIsActivated;
        if(forwardPressed || leftPressed || backwardPressed || rightPressed){
            animator.SetBool("IsRunning", true);

        }
        else {
             animator.SetBool("IsRunning", false);
        }

        if(hasWon)
        {
            animator.SetBool("hasWon", true);
        }

        if(isDead)
        {
            animator.SetBool("isDead", true);
        }
        else {
            animator.SetBool("isDead", false);
        }

        if(isJumping)
        {
            animator.SetBool("isJumping", true);
            
        }
        else {
            animator.SetBool("isJumping", false);
            
        }

        if(isJumpingDown)
        {
            animator.SetBool("isJumpingDown", true);
            
        }
        else {
            animator.SetBool("isJumpingDown", false);
        }

        /* if(isActivated)
        {
            animator.SetBool("isActivated", true);
        }
        else {
            animator.SetBool("isActivated", false);
        }
        */
    }
}
