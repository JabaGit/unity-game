using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public GameObject DeathEffect;
    public static bool playerIsDead;
    public float duration = 2f;
    public PlayerStats playerstats;
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
        playerIsDead = true;
        playerstats.calculateDamage(100);
        yield return new WaitForSeconds(duration);
        playerIsDead = false;
        player.transform.position = playerMovement.checkpoint;
        playerMovement.controller.enabled = true;
    }
}
