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
    public float timer;
    // Hur mycket skada playern gör när den skadar - Alexander
    void Update()
    {

        timer += Time.deltaTime;

        if (Input.GetKeyDown(punch) && timer >= 1)
            {
                attack();
              timer = 0;

            AudioManager.Instance.PlaySFX("Hit");
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
