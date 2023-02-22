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
    public float timerHurt = 2;

    // Hälsa och om man tar skada och spelar animationer beroende på om man tar skada. - Alexander och jack
    void Start()
    {
        currentHealth = health;
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        loseMenu.SetActive(false);
        neverDone = true;
    }
    public void TakeDamage(int damage)
    {
        timerHurt = 0;
        currentHealth -= damage;
        


    }
    void Update()
    {
        if (timerHurt > 0.7f && timerHurt < 1)

        {
            animator.SetTrigger("Hurt");

        }
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
        


        // Används för att man ska hinna se death animation innan menyn kommer upp -Alexander

        if (timer > 2f && timer < 2.5)
        {
            loseMenu.SetActive(true);


        }
    }


    // Tittar om man koliderar med massa olika saker. -Alexander
    public void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Soda")
        {
            Destroy(collision.gameObject);
            AudioManager.Instance.PlaySFX("Soda");

        }


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
