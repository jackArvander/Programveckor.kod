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

    // Start is called before the first frame update
    void Start()
    {
        firstMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == targetPos1)
        {
            firstMove = false;
        }
        if (transform.position == targetPos2)
        {
            firstMove = true;
        }
        if (canMove) // Om den kan röra sig rör den sig till punkt A, när på A gå till B - Jack
        {
            if (firstMove)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos1, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPos2, speed * Time.deltaTime);
            }
        }
    }
   


}





