using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finisher : MonoBehaviour
{
    public GameObject winningText;
    public static bool playerHasWon = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            

            winningText.SetActive(true);
            playerHasWon = true;
            //Debug.Log("Bool hasWon", playerHasWon);
            
            
            //SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHasWon = false;
            //SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }


}
