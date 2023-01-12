using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public KeyCode attack;
    public bool enemyHitbox; 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKey(attack))
        {
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);

            }
        }
       
        
        if (collision.gameObject.tag == "Enemy")
        {
            enemyHitbox = true;
        }
        else
        {
            enemyHitbox = false;
        }
    }
}
