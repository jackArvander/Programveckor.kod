using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// by vincent, jag vet inte vad dens används för
public class Floater : MonoBehaviour
{

    public Rigidbody2D rb;
    public float depthBeforeSubmerged = 1f;
    public float displacementAmount = 3f;

    private void FixedUpdate()
    {

        if (transform.position.y < 0f)
        {

            float dispacementMultiplier = Mathf.Clamp01(-transform.position.y / depthBeforeSubmerged) * displacementAmount;
            rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementAmount));

        }
        
    }

}
