using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public GameObject DeathEffect;
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
        Instantiate(DeathEffect, player.transform.position, player.transform.rotation);
        ThirdPersonMovment playerMovement = player.GetComponent<ThirdPersonMovment>();
        playerMovement.controller.enabled = false;
        yield return new WaitForSeconds(duration);
        player.transform.position = playerMovement.checkpoint;
        playerMovement.controller.enabled = true;
    }
}
