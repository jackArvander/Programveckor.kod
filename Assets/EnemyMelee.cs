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
    public float timerhurt = 4;
    public bool hasDone = true;
    // Fiendens skada och att den gör animationen i tid - Alexander
    void Update()
    {

        timer += Time.deltaTime;
        timerhurt += Time.deltaTime;

        if (timer >= 3)
        {
            attack();
            timer = 0;
        }

        if (hasDone == true)
        {
            if (timerhurt > 0.07f && timerhurt < 0.1f)
            {
                Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayer);
                foreach (Collider2D player in hitPlayer)
                {
                    player.GetComponent<HeathSystem>().TakeDamage(attackDamage);
                }
                hasDone = false;
            }

        }


    }
    void attack()
    {
        animator.SetTrigger("attack");
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
