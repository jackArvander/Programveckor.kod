using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest : MonoBehaviour
{

    [SerializeField] ParticleSystem CollectParticle = null;

    private void Awake()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            collect();

        }
        
    }

    public void collect()
    {

        CollectParticle.Play();

    }

}
