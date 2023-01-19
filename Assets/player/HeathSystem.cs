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
    public float timer = 4;
    public bool neverDone = true;

    public GameObject loseMenu;
    public bool isDeath = false;
    public float timerHurt = 1;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        loseMenu.SetActive(false);
        neverDone = true;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");


    }
    // Update is called once per frame
    void Update()
    {
        timerHurt += Time.deltaTime;
        
        timer += Time.deltaTime;
        if (neverDone == true)
        {
            if (currentHealth <= 0) 
            {
                timer = 0;
                AudioManager.Instance.PlaySFX("Defeat");
                neverDone = false;

            }
        }
        if (currentHealth <= 0)
        {
            animator.SetBool("Die", true);
            GameObject.Find("Ratte(player) 1").GetComponent<movement>().enabled = false;
            GameObject.Find("Ratte(player) 1").GetComponent<Attack>().enabled = false;
            Destroy(GetComponent<Rigidbody2D>());


        }
        

        // när du förlorar



        if (timer > 2.4f && timer < 3.49)
        {
            loseMenu.SetActive(true);


        }
    }



    public void OnCollisionEnter2D(Collision2D collision)

    {


        if (collision.gameObject.tag == "water")
        {

            currentHealth = -1;

            animator.SetTrigger("TouchWater");

        }
        if (collision.gameObject.tag == "water" && currentHealth <= 0)
        {

            animator.SetBool("DieWater", true);

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
