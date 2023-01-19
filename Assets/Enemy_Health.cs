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


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        neverDone = true;

    }
    void Update()
    {
        timerHurt += Time.deltaTime;
        timer += Time.deltaTime;

        if (timer > 1.4f && timer < 1.49)
        {
            Destroy(this.gameObject);
        }
        if (neverDone == true)
        {
            if (timerHurt > 0.7f && timerHurt < 1)

            {
                animator.SetTrigger("Hurt");
                neverDone = false;
            }
        }
        
    }

    public void TakeDamage(int damage)
    {
        animator.SetTrigger("Hurt");
        currentHealth -= damage;
        timerHurt = 0;
        if (currentHealth <= 0)
        {
            animator.SetBool("Dead", true);
            timer = 0f;
        }
    }



}

