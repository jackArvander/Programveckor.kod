using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Animator animator;
    public float timer =1.6f;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1.4f && timer < 1.49)
        {
            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        animator.SetTrigger("Hurt");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            animator.SetBool("Dead", true);
            timer = 0f;
        }
    }



}

