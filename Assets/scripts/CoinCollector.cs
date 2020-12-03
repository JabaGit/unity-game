using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public GameObject BoostEffect;
    public float duration = 3f;
    public float multiplier = 1.5f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Boost(other));
        }
    }

    IEnumerator Boost(Collider player)
    {
        Instantiate(BoostEffect, transform.position, transform.rotation);


        

        ThirdPersonMovment playerMovement = player.GetComponent<ThirdPersonMovment>();
        playerMovement.speed *= multiplier;

        //Make Boost Object invisible
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        playerMovement.speed /= multiplier;

        Destroy(gameObject);
    }
}