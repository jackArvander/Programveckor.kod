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
    public KeyCode superJump;
    public KeyCode slam;
    public KeyCode reset;
    public int Keys;
    public float force;
    public float jumpForce;
    public float superjumpForce;
    public float slamForce;
    public bool isGrounded;
    public bool isSlamming;
    public bool powerup;
    float timer;
    public Animator animator;




    void Update()
    {

        // Makes the character move - Alexander
        if (Input.GetKey(left))
        {
            rb2d.AddForce(Vector3.left * force * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 1);

            animator.SetFloat("Speed", 1);

        }
        else if (Input.GetKey(right))
        {
            rb2d.AddForce(Vector3.right * force * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetFloat("Speed", 1);


        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
        if (Input.GetKeyDown(slam) && isSlamming == false && isGrounded == false)
        {
            rb2d.AddForce(Vector3.down * slamForce);
            isSlamming = true;
        }
        if (Input.GetKeyDown(jump) && isGrounded == true)
        {
            animator.SetBool("IsAired", true);

            if (powerup == true)
            {
                rb2d.AddForce(Vector3.up * jumpForce * superjumpForce);
                isGrounded = false;
            }
            if (powerup == false)
            {
                rb2d.AddForce(Vector3.up * jumpForce);
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
            animator.SetBool("IsAired", false);


        }
        else
        {
            rb2d.mass = 5;
            rb2d.drag = 1;
            
        }

        timer += Time.deltaTime;

        if (timer > 10)
        {
            powerup = false;
        }

    }
   
    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            isSlamming = false;

        }
        if (collision.gameObject.tag == "Powerup")
        {
            isGrounded = true;
            powerup = true;
            Destroy(collision.gameObject);
            timer = 0;


        }

    }

}
