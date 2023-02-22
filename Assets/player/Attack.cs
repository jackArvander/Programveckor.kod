using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //Alexander
    public KeyCode punch;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 40;
    public LayerMask enemyLayer;
    public Animator animator;
    public float timer;
    public float timerhurt = 4;
    public bool hasDone = true;

    // Hur mycket skada playern gör när den skadar - Alexander
    void Update()
    {

        timer += Time.deltaTime;
        timerhurt += Time.deltaTime;

        if (Input.GetKeyDown(punch) && timer >= 1)
            {
                attack();
              timer = 0;

            AudioManager.Instance.PlaySFX("Hit");
            }

        if (hasDone == true)
        {
            if (timerhurt > 0.1f && timerhurt < 0.3f)
            {
                Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
                foreach (Collider2D enemy in hitEnemies)
                {
                    enemy.GetComponent<Enemy_Health>().TakeDamage(attackDamage);
                }
                hasDone = false;
            }
        }
    }

    void attack()
    {
        animator.SetTrigger("Attack");
        timerhurt = 0;
        hasDone = true;

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
