using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    float previousHorizontalInput;
    float previousHorizontalDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerStay2D(Collider2D other)
    {
    }
    void Update()
    {
        float currentHorizontalDirection = transform.localScale.x;
        if (currentHorizontalDirection != previousHorizontalDirection)
        {
            if (currentHorizontalDirection < 0)
            {
                transform.localScale = new Vector2(-1, 1);
            }
            else if (currentHorizontalDirection > 0)
            {
                transform.localScale = new Vector2(1, 1);
            }
            previousHorizontalDirection = currentHorizontalDirection;
        }
    }
}

