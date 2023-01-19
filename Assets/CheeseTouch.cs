using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseTouch : MonoBehaviour
{

    public GameObject winMenu;
    public float timer = 4;

    public bool isWon = false;
    public Animator animator;

    private void Start()
    {

        winMenu.SetActive(false);
        
    }

    private void Update()
    {
        timer += Time.deltaTime;


        if (timer > 2.4f && timer < 2.49)
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

    void victory()
    {

    winMenu.SetActive(true);
    }

}
