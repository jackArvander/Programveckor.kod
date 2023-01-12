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
        if (health<=0) //om livet tar slut så händer x - Jack
        {

        }
    }

    public void OnTriggerEnter2D(Collider2D collision) // om player rör vatten så tp till spawn
    {
        if (collision.gameObject.tag == "water")
        {

            transform.position = new Vector3(-37, -4, -8);

        }

    }
}
