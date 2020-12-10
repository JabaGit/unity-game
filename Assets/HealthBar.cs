using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Text healthNumber;

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
    


}
