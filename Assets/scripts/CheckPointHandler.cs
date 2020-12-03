using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointHandler : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            setCheckPoint(other);
        }
    }
    void setCheckPoint(Collider player)
    {
        ThirdPersonMovment playerMovement = player.GetComponent<ThirdPersonMovment>();
        playerMovement.checkpoint = player.transform.position;
    }
}
