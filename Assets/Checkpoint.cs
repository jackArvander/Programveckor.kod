using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// skapad av vincent fajersson
public class Checkpoint : MonoBehaviour
{


    private GameMaster gm; 

    private void Start()
    {

        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>(); // hittar gameObject med en tag "GM" (Game master)
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            gm.lastCheckPointPos = transform.position;

        }
        
    }

}
