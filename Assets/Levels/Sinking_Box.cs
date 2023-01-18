using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinking_Box : MonoBehaviour
{

    [SerializeField]
    public Vector3 targetPos1; 
    [SerializeField]
    public Vector3 targetPos2;
    [SerializeField]
    public float speed = 1f;
    public bool canMove;
    public bool firstMove;
    public bool sinking;


    // Start is called before the first frame update
    void Start()
    {
     

    }


    void Update()
    {
        if (transform.position == targetPos1)
        {
            sinking = false;

        }
        if (sinking == true)
        {
            GameObject.Find("SinkBox").GetComponent<Animator>().Play("Sink");


            transform.position = Vector2.MoveTowards(transform.position, targetPos1, speed * Time.deltaTime);
        }
        if (sinking == false)
        {

            transform.position = Vector2.MoveTowards(transform.position, targetPos2, 1 * Time.deltaTime);
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Player")
        {
            sinking = true;
        }

    }

}
