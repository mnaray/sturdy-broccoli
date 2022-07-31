using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public void OnStart(){
        SceneManager.LoadScene("PrimaryScene");
    }
    public void OnQuit(){
        print("QUITTING THE GAME!");
        Application.Quit();
    }
    public void OnOptions(){
        Debug.Log("lmao does it look like we have options");
    }
}
