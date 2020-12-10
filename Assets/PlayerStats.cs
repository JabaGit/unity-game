using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public HealthBar healthbar;
    public int numberOfLifes;
    private int health;

    public GameObject deathText;
    
    // Start is called before the first frame update
    void Start()
    {
         healthbar.SetMaxHealth(100);
         health = 100;
         numberOfLifes = 3;
         healthbar.setHealthNumber(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void calculateDamage(int damage){

    
    health = health - damage;
    
    if(health > 0)
    {
        healthbar.SetHealth(health);
        healthbar.setHealthNumber(health);
    }
    else {
        if((numberOfLifes-1)>=0){
            health = 100;
            healthbar.SetHealth(health);
            healthbar.setHealthNumber(health);
            numberOfLifes--;
            Debug.Log("You Lost a Life");
            Debug.Log(numberOfLifes + " life left");
        }
        else {
            deathText.SetActive(true);
            Debug.Log("Verloren");
        }
    }

    }

}
