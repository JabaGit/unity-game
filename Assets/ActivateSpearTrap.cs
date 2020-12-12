using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpearTrap : MonoBehaviour
{
    public static bool spearIsActivated;
    public GameObject Spear;
    public GameObject Spear1;
    public GameObject Spear2;
    public GameObject Spear3;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spearIsActivated = true;
            Spear.GetComponent<Animation>().Play("Anim_SpearTrap_Play");
            Spear1.GetComponent<Animation>().Play("Anim_SpearTrap_Play");
            Spear2.GetComponent<Animation>().Play("Anim_SpearTrap_Play");
            Spear3.GetComponent<Animation>().Play("Anim_SpearTrap_Play");
            StartCoroutine(playAnimation());
           


            
           
          
        }
    }


    IEnumerator playAnimation(){

        
        yield return new WaitForSeconds(1.5f);
        Spear.GetComponent<Animation>().Rewind("Anim_SpearTrap_Play");
        Spear1.GetComponent<Animation>().Rewind("Anim_SpearTrap_Play");
        Spear2.GetComponent<Animation>().Rewind("Anim_SpearTrap_Play");
        Spear3.GetComponent<Animation>().Rewind("Anim_SpearTrap_Play");
        

    }

    void OnTriggerExit(Collider other){

        Debug.Log("Exit the Spear Trigger");
        
    }

}
