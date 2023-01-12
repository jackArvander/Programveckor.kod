using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathSystem : MonoBehaviour
{
    private float health = 100;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {  
        if (health<=0) //När livet når <=0 så förstörs Taggen player - Jack
        {
            //Destroy(GameObject.FindWithTag("player"));
            transform.position = new Vector3(-37, -4, -8);
            health= 100;
        }

        

    }

    public void OnTriggerEnter2D(Collider2D collision) // om player rör vatten så dör man
    {
        if (collision.gameObject.tag == "water")
        {

            health = 0;

        }

        if (collision.gameObject.tag == "em")
        {

            health = 0;

        }
    }
}
