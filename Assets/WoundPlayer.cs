using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoundPlayer : MonoBehaviour
{

    public PlayerStats playerstats;
    public int damage = 10;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hit");
            playerstats.calculateDamage(damage); 
        }
    }

}
