using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
        if (currentHealth < 0)
        {
            die();
        }
    }
    void die()
    {
        Debug.Log("Enemy ded");
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        Destroy(this.gameObject);

    }

}
