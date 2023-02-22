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

        StartCoroutine(EnableAfterTime()); // s�ger till att starta en timer som kontrollerar sj�lva systemet f�r vattnet

    }

    IEnumerator EnableAfterTime() // sj�lva timern
    {
        while (true)
        {
            theFlood = true; // g�r s� att "theFlood" blir true som startar animationen f�r vattnet
            yield return new WaitForSeconds(13); // det h�r g�r s� att koden v�ntar en m�ngd sekunder
            theFlood = false;
            yield return new WaitForSeconds(17);
        }
    }

    void Update()
    {

        if (theFlood == true)
        {

            animator.SetBool("TriggerFlood", true); // n�r theFlood �r true i timern s� blir animation true och g�r ig�ng

        }
        else
        {

            animator.SetBool("TriggerFlood", false); // annars ska den inte spela animationen

        }
        
    }

    void TriggerFlood() // det som h�ller boolen f�r animator i unity
    {

        theFlood = true;

    }
    void UnTriggerFlood()
    {

        theFlood = false;

    }
}
