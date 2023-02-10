using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Animator animator;
    public float timer =1.6f;
    public float timerHurt = 2;
    public bool neverDone = true;

    // Tittar hur mycket fienden tål och hur mycket skada den tar - Alexander
     void Start()
    {
        currentHealth = maxHealth;
        neverDone = true;

    }
    void Update()
    {
        timerHurt += Time.deltaTime;
        timer += Time.deltaTime;

        if (timer > 1f && timer < 1.1)
        {
            Destroy(this.gameObject);
        }

        
    }

    public void TakeDamage(int damage)
    {
        animator.SetTrigger("Hurt");
        neverDone = true;

        currentHealth -= damage;
        timerHurt = 0;
        if (currentHealth <= 0)
        {
            animator.SetBool("Dead", true);
            timer = 0f;
        }
    }



}

