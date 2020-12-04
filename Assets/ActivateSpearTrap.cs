using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpearTrap : MonoBehaviour
{
    public static bool spearIsActivated;
    public GameObject Spear;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spearIsActivated = true;
           Spear.GetComponent<Animation>().Play("Anim_SpearTrap_Play");
          
        }
    }

}
