using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotater : MonoBehaviour
{
    public Transform body;
    public float rotationSpeed = 2f;
    Vector3 direction;
    public float duration = 0f;
    public float pushbackFactor = 5f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(Pushback(other));
           
        }
    }

    private IEnumerator Pushback(Collider player)
    {
        Debug.Log("Direction: " + direction);
        direction = transform.position - player.transform.position;
        direction = direction.normalized;
        ThirdPersonMovment playerMovement = player.GetComponent<ThirdPersonMovment>();
        //playerMovement.controller.enabled = false;
        playerMovement.impact = direction * pushbackFactor;
        
        yield return new WaitForSeconds(duration);

        //playerMovement.controller.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        body.Rotate(new Vector3(0, rotationSpeed, 0));
        
        
    }
}
