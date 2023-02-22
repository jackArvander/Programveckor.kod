using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    //försök till en health bar som inte funkade - jack
    
        public HeathSystem playerHealthScript;
        public Slider healthBar;

        private void Start()
        {
            playerHealthScript = GetComponent<HeathSystem>();
           
        }

        private void UpdateHealthBar(float currentHealth)
        {
            healthBar.value = currentHealth;
        }
    

}
