using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    //Alexander som har gjort
    [SerializeField]
    public Rigidbody2D rb2d;
    public KeyCode right;
    public KeyCode left;
    public KeyCode jump;
    public KeyCode superJump;
    public KeyCode reset;
    public int Keys;
    public float force;
    public float jumpForce;
    public float superjumpForce;
    public float slamForce;
    public bool isGrounded;
    public bool powerup;
    float timer;
    public Animator animator;




    void Update()
    {

        // Makes the character move - Alexander
        if (Input.GetKey(left))
        {
            rb2d.AddForce(Vector3.left * force * Time.deltaTime);
            transform.localScale = new Vector3(-2, 2, 2);

            animator.SetFloat("Speed", 1);

        }
        else if (Input.GetKey(right))
        {
            rb2d.AddForce(Vector3.right * force * Time.deltaTime);
            transform.localScale = new Vector3(2, 2, 2);
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
        
        if (Input.GetKeyDown(jump) && isGrounded == true)
        {
            animator.SetBool("IsAired", true);
            animator.SetTrigger("Begin Jump");
            AudioManager.Instance.PlaySFX("Jump");

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
        // Tittar om man ?r p? marken och ?ndrar animationer - Alexander

        if (isGrounded == true)
        {
            
            rb2d.mass = 3;
            rb2d.drag = 2;
            animator.SetBool("IsAired", false);


        }
        else
        {
            rb2d.mass = 3;
            rb2d.drag = 6;
            
        }

        timer += Time.deltaTime;

        if (timer > 6)
        {
            powerup = false;
        }

    }
   
    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;

        }
        if (collision.gameObject.tag == "Powerup")
        {
            powerup = true;
            Destroy(collision.gameObject);
            timer = 0;


        }


    }

}
