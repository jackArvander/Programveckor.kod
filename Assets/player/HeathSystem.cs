using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathSystem : MonoBehaviour
{
    public float health = 100;
    [SerializeField] Healthbar _healthbar;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {  
        if (health<=0) //N�r livet n�r <=0 s� f�rst�rs Taggen player - Jack
        {
            //Destroy(GameObject.FindWithTag("player"));
            transform.position = new Vector3(-37, -4, -8);
            health = 100;
            animator.SetTrigger("Die");

        }



    }

    public void OnCollisionEnter2D(Collision2D collision)

    {


        if (collision.gameObject.tag == "Enemy")
        {

            health = health-20;

        }
        if (collision.gameObject.tag == "healing powerup")
        {

            health = health +50;

            Destroy(GameObject.FindWithTag("healing powerup"));
        }
    }
    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "water")
        {

            health = 0;

        }
    }

}
