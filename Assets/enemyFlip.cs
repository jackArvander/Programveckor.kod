using UnityEngine;

public class enemyFlip : MonoBehaviour
{
    private SpriteRenderer enemySpriteRenderer;
    private Rigidbody2D enemyRigidbody2D;

    private void Start()
    {
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        enemyRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (enemyRigidbody2D.velocity.x > 0)
        {
            enemySpriteRenderer.flipX = false;
        }
        else if (enemyRigidbody2D.velocity.x < 0)
        {
            enemySpriteRenderer.flipX = true;
        }
    }
}
