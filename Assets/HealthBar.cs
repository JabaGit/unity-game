using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Text healthNumber;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public void SetHealth(int health)
    {
    slider.value = health;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        //life.text = numberOfLifes.ToString();
    }
    
      public void setHealthNumber(int health)
    {
        healthNumber.text = health.ToString();
    }

    public void destroyHeart(int i){

        if(i==1)
        {
            heart1.SetActive(false);
        }
         if(i==2)
        {
            heart2.SetActive(false);
        }
         if(i==3)
        {
            heart3.SetActive(false);
        }

    }
    


}
