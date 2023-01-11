using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{


    [SerializeField]
    public Rigidbody2D rb2d;
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public KeyCode bigJump;
    public KeyCode slam;
    public KeyCode reset;
    public int Keys;
    public float force;
    public float jumpForce;
    public float bigJumpForce;
    public float slamForce;
    public bool isGrounded;
    public bool isSlamming;




    void Update()
    {


        if (Input.GetKey(right))
        {
            rb2d.AddForce(Vector3.right * force * Time.deltaTime);
        }
        if (Input.GetKey(left))
        {
            rb2d.AddForce(Vector3.left * force * Time.deltaTime);
        }
        if (Input.GetKeyDown(slam) && isSlamming == false && isGrounded == false)
        {
            rb2d.AddForce(Vector3.down * slamForce);
            isSlamming = true;
        }
        if (Input.GetKeyDown(jump) && isGrounded == true && !Input.GetKey(bigJump))
        {
            rb2d.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
        }
        if (Input.GetKey(bigJump) && isGrounded == true)
        {
            if (Input.GetKeyDown(jump) && isGrounded == true)
            {
                rb2d.AddForce(Vector3.up * jumpForce * bigJumpForce);
                isGrounded = false;
            }
        }
        if (Input.GetKeyDown(reset))
        {
            transform.position = new Vector3(-37, -4, -8);
        }
        if (isGrounded == true)
        {
            
            rb2d.mass = 3;
            rb2d.drag = 2;

        }
        else
        {
            rb2d.mass = 5;
            rb2d.drag = 1;

        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            isSlamming = false;

        }


    }
}