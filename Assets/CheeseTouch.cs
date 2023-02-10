using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseTouch : MonoBehaviour
{

    public GameObject winMenu;
    public float timer = 4;

    public bool isWon = false;
    public Animator animator;
    //Tittar om man rör den vinnande osten - Vincent
    private void Start()
    {

        winMenu.SetActive(false); // gör vinst menyn inte aktiv så du inte kan bara skippa olika banor
        
    }

    private void Update()
    {
        timer += Time.deltaTime;


        if (timer > 2.4f && timer < 2.49) // timer så att victory() koden inte spelas på direkten
        {
            victory();
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            isWon = true;
            animator.SetBool("Has Won", true);
            timer = 0;
            AudioManager.Instance.PlaySFX("Victory");

        }

        

    }

    void victory() // gör winMenu till true
    {

    winMenu.SetActive(true);

    }

}
