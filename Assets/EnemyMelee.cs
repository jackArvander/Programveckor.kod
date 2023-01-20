using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 40;
    public LayerMask playerLayer;
    public Animator animator;
    public float timer;
   // Fiendens skada och att den gör animationen i tid - Alexander
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= 3)
        {
            animator.SetTrigger("attack");
            attack();
            timer = 0;
        }


    }
    void attack()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
        foreach (Collider2D player in hitPlayer)
        {
            player.GetComponent<HeathSystem>().TakeDamage(attackDamage);
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
