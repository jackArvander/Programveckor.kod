using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// skapad av vincent
public class waterie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D trigger)
    {
        if (trigger.gameObject.tag == "vatten")
        {
            transform.position = new Vector3(-37, -4, -8);
        }
    }
}
