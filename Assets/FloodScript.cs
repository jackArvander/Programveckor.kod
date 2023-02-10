using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Animations;

public class FloodScript : MonoBehaviour
{

    public Transform floodObject;
    public Animator animator;

    float floodSpeed = 5f;

    public bool theFlood = false;

    void Start()
    {


        
    }



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {

            AudioManager.Instance.PlaySFX("Warning"); // spelar ljud när jag trycker på R

            TriggerFlood(); // runs the TriggerFlood script

        }

        if (theFlood == true)
        {

            print("tHE FLOOD HAS STARTED");

            animator.SetBool("TriggerFlood", true);

        }
        
    }

    void TriggerFlood() // information för TriggerFlood kod
    {

        theFlood = true; // gör theFlood till true

    }
}
