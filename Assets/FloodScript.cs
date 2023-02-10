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

            AudioManager.Instance.PlaySFX("Warning"); // spelar ljud n�r jag trycker p� R

            TriggerFlood(); // runs the TriggerFlood script

        }

        if (theFlood == true)
        {

            print("tHE FLOOD HAS STARTED");

            animator.SetBool("TriggerFlood", true);

        }
        
    }

    void TriggerFlood() // information f�r TriggerFlood kod
    {

        theFlood = true; // g�r theFlood till true

    }
}
