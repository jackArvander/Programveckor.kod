using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
        animator.SetTrigger("Hurt");
        if (currentHealth < 0)
        {
            animator.SetBool("Die", true);

            die();
        }
    }
    void die()
    {
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
       // Destroy(this.gameObject);

    }

}

