using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class reset : MonoBehaviour
{
   

    public KeyCode reeet;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(reeet))
        {
            transform.position = new Vector3(-56, 2, 8);
            animator.SetBool("Die", false);
            animator.SetBool("WaterDie", false);

        }
    }
}
