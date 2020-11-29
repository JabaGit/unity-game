using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPlayScript : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Main menu button pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Main menu button pressed");
    }
}
