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
        if (health<=0) //om livet tar slut s� h�nder x - Jack
        {

        }
    }

    public void OnTriggerEnter2D(Collider2D collision) // om player r�r vatten s� tp till spawn
    {
        if (collision.gameObject.tag == "water")
        {

            transform.position = new Vector3(-37, -4, -8);

        }

    }
}
