using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public KeyCode punch;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 40;
    public LayerMask enemyLayer;
    public Animator animator;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    float timer;
    void Update()
    {
        timer += Time.deltaTime;

        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(punch))
            {
                attack();
                nextAttackTime = Time.time + 1f / attackRate; 
            }
        }
        
    }
    void attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies= Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy_Health>().TakeDamage(attackDamage);
        }

    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
