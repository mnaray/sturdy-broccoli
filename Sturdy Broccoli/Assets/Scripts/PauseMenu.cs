using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        // opens the pause menu and freezes the game
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        // closes the pause menu and unfreezes the game
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        // prints into console as it's not possible
        // to quit in unity debug mode
        print("QUITTING THE GAME!");
        Application.Quit();
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
