using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finisher : MonoBehaviour
{
    public GameObject winningText;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            

            winningText.SetActive(true);
            
            
            //SceneManager.LoadScene(sceneName: "MainMenu");
        }
    }
}
