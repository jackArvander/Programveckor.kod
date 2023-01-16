using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
        Slider _HealthSlider;
    private void Start()
    {
        _HealthSlider = GetComponent<Slider>();
    }

    public void SetMaxHealth(int maxHealth)
    {
        _HealthSlider.maxValue = maxHealth;
        _HealthSlider.value = maxHealth;
    }
    public void SetHealth(int Health)
    {
        GetComponent<HeathSystem>();
        _HealthSlider.value = Health;

    }
    
}
