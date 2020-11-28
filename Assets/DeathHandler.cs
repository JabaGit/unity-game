using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public float duration = 1f;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Zack");
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Boost(other));
        }
    }

    IEnumerator Boost(Collider player)
    {
        ThirdPersonMovment playerMovement = player.GetComponent<ThirdPersonMovment>();
        
        yield return new WaitForSeconds(duration);
        player.transform.position = playerMovement.checkpoint;
    }
}
