using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseTouch : MonoBehaviour
{

    public GameObject winMenu;

    public bool isWon = false;


    private void Start()
    {

        winMenu.SetActive(false);
        
    }

    private void Update()
    {

        if (isWon == true)
        {

            victory();

        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {

            isWon = true;

        }

    }

    void victory()
    {

        winMenu.SetActive(true);

    }

}
