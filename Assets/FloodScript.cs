using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Animations;

// skapad av vincent fajersson
public class FloodScript : MonoBehaviour
{

    public Transform floodObject;
    public Animator animator;

    float floodSpeed = 5f;

    public bool theFlood = false;

    void Start()
    {

        StartCoroutine(EnableAfterTime()); // säger till att starta en timer som kontrollerar själva systemet för vattnet

    }

    IEnumerator EnableAfterTime() // själva timern
    {
        while (true)
        {
            theFlood = true; // gör så att "theFlood" blir true som startar animationen för vattnet
            yield return new WaitForSeconds(13); // det här gör så att koden väntar en mängd sekunder
            theFlood = false;
            yield return new WaitForSeconds(17);
        }
    }

    void Update()
    {

        if (theFlood == true)
        {

            animator.SetBool("TriggerFlood", true); // när theFlood är true i timern så blir animation true och går igång

        }
        else
        {

            animator.SetBool("TriggerFlood", false); // annars ska den inte spela animationen

        }
        
    }

    void TriggerFlood() // det som håller boolen för animator i unity
    {

        theFlood = true;

    }
    void UnTriggerFlood()
    {

        theFlood = false;

    }
}
