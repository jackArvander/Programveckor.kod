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

        if (Input.GetKeyDown(KeyCode.Escape))
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

    public void PauseGame()
    {

        Time.timeScale = 0f;
        isPaused = true;

    }

    public void ResumeGame()
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

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public async void Credits()
    {

        SceneManager.LoadScene("Credits");

    }

    public void Continue()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }



}
