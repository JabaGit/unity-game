using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearTrapDeathHandler : MonoBehaviour
{
    //public GameObject DeathEffect;
    public static bool playerIsDead;
    public float duration = 2f;
    public PlayerStats playerstats;
    public int damage = 50;

   

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hit");
            StartCoroutine(Boost(other));
        }
    }

    IEnumerator Boost(Collider player)
    {
        //Instantiate(DeathEffect, player.transform.position, player.transform.rotation);
        ThirdPersonMovment playerMovement = player.GetComponent<ThirdPersonMovment>();
        playerMovement.controller.enabled = false;
        playerIsDead = true;
        playerstats.calculateDamage(damage);
    
        yield return new WaitForSeconds(duration);
        playerIsDead = false;
        player.transform.position = playerMovement.checkpoint;
        playerMovement.controller.enabled = true;
    }
}