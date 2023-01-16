using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector2 direction = (other.transform.position - transform.position).normalized;
            rb.AddForce(direction * moveSpeed);

            // Uncomment the following line if you want the enemy to rotate towards the player
            //transform.rotation = Quaternion.LookRotation(other.transform.position - transform.position);
        }
    }
}
