using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject pauseMenu;

    public bool isPaused;

    private void Start()
    {

        pauseMenu.SetActive(false);
        
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

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }

    public void ResumeGame()
    {

        pauseMenu?.SetActive(false);
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

    public void Credits()
    {

        SceneManager.LoadScene("Credits");

    }

    public void Continue()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
