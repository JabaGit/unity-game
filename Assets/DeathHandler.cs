using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public float duration = 1f;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Boost(other));
        }
    }

    IEnumerator Boost(Collider player)
    {
        ThirdPersonMovment playerMovement = player.GetComponent<ThirdPersonMovment>();
        
        yield return new WaitForSeconds(duration);
        Debug.Log("Pl Pos:" + player.transform.position + "Check Pos:" + playerMovement.checkpoint);
        player.transform.position = playerMovement.checkpoint;
    }
}
