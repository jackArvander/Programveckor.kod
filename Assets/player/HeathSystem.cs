using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathSystem : MonoBehaviour
{
    public float health = 100;
    public float currentHealth;
    [SerializeField] Healthbar _healthbar;
    public Animator animator;
    public KeyCode reeet;

    public GameObject loseMenu;
    public bool isDeath = false;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        loseMenu.SetActive(false);

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");

    }
    // Update is called once per frame
    void Update()
    {  
        if (currentHealth<=0) //N�r livet n�r <=0 s� f�rst�rs Taggen player - Jack
        {

            animator.SetBool("Die", true);
            GameObject.Find("Ratte(player) 1").GetComponent<movement>().enabled = false;
            GameObject.Find("Ratte(player) 1").GetComponent<Attack>().enabled = false;
            this.enabled = false;
            Destroy(GetComponent<Rigidbody2D>());

            isDeath = true;


        }
        if (Input.GetKeyDown(reeet))
        {
            transform.position = new Vector3(-5, -3, -8);
            animator.SetBool("Die", false);

        }

        // när du förlorar
        if (isDeath == true)
        {

            defeat();

        }


    }

    void defeat()
    {

        loseMenu.SetActive(true);

    }

    public void OnCollisionEnter2D(Collision2D collision)

    {


        if (collision.gameObject.tag == "water")
        {

            currentHealth = 0;

            animator.SetTrigger("TouchWater");

        }
        if (collision.gameObject.tag == "water" && currentHealth <= 0)
        {

            animator.SetBool("DieWater", true);

        }

        if (collision.gameObject.tag == "Enemy")
        {

            currentHealth -= 20;

        }
        if (collision.gameObject.tag == "healing powerup")
        {
            Destroy(collision.gameObject);
            currentHealth = 100;


        }
    }
    public void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.gameObject.tag == "water")
        {

            currentHealth = 0;

            animator.SetTrigger("TouchWater");

        }
        if (collision.gameObject.tag == "water" && currentHealth <= 0)
        {

            animator.SetBool("DieWater", true);

        }
    }

}
