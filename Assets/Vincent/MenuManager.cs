using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// hanterar all UI - vincent
public class MenuManager : MonoBehaviour
{

    public GameObject GM;

    public bool isPaused;

    private void Start()
    {

        
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) // pauses tha game!
        {

            if (isPaused)
            {

                ResumeGame();

            }
            else
            {

                PauseGame();

            }

        }
        
    }

    public void PauseGame() // g�r timeScale i spelet till 0 s� att ingenting kan r�ra sig
    {

        Time.timeScale = 0f;
        isPaused = true;

    }

    public void ResumeGame() // g�r timeScale till ett igen s� att allting kan r�ra sig igen
    {

        Time.timeScale = 1f;
        isPaused = false;

    }

    public void GoToMainMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");


    }

    public void QuitGame()
    {

        Application.Quit();

    }

    public void PlayGame()
    {

        SceneManager.LoadScene("Level2");

    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // tar den aktiva scenen och startar den, s� den bara startar om niv�n.

    }

    public void Credits()
    {

        SceneManager.LoadScene("Credits");

    }

    public void Continue()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // den tar den aktiva niv�n +1, s� den tar n�sta aktiva scen i spelet.

    }



}
