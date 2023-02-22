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

    public void PauseGame() // gör timeScale i spelet till 0 så att ingenting kan röra sig
    {

        Time.timeScale = 0f;
        isPaused = true;

    }

    public void ResumeGame() // gör timeScale till ett igen så att allting kan röra sig igen
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

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // tar den aktiva scenen och startar den, så den bara startar om nivån.

    }

    public void Credits()
    {

        SceneManager.LoadScene("Credits");

    }

    public void Continue()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // den tar den aktiva nivån +1, så den tar nästa aktiva scen i spelet.

    }



}
