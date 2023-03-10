using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField]
    public Vector3 targetPos1; //targetPos = points of movement - Jack
    [SerializeField]
    public Vector3 targetPos2;
    [SerializeField]
    public float speed = 1f;
    public bool canMove;
    public bool firstMove;
    private SpriteRenderer enemySpriteRenderer;
    private Rigidbody2D enemyRigidbody2D;

    void Start()
    {
        firstMove = true;
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        enemyRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position == targetPos1)
        {
            firstMove = false;
            transform.localScale = new Vector3(-2, 2, 2);
        }
        else if (transform.position == targetPos2)
        {
            firstMove = true;
            transform.localScale = new Vector3(2, 2, 2);
        }
        if (canMove) // Om den kan r?ra sig r?r den sig till punkt A, n?r p? A g? till B - Jack
        {
            if (firstMove)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPos1, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPos2, speed * Time.deltaTime);
                if (transform.position == targetPos2)
                {
                    firstMove = true;
                }
            }
        }
    }
}
            

