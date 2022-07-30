using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit() {
        print("QUITTING THE GAME!");
        Application.Quit();
    }
}
