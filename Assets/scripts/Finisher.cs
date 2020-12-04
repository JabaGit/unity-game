using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finisher : MonoBehaviour
{
    public GameObject winningText;
    public static bool playerHasWon = false;

     // Start is called before the first frame update
    // ThirdPersonMovment playerMovement;

    void Start()
    {
        //playerMovement = GetComponent<ThirdPersonMovment>();
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ThirdPersonMovment playerMovement = other.GetComponent<ThirdPersonMovment>();
            playerMovement.controller.enabled = false;
            winningText.SetActive(true);
            playerHasWon = true;
            //Debug.Log("Bool hasWon", playerHasWon);
        }
    }


}
