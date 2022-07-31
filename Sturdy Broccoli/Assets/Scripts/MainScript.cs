using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainScript : MonoBehaviour
{
    public void OnStart(){
        SceneManager.LoadScene(2);
    }
    public void OnQuit(){
        Application.Quit();
    }
    public void OnOptions(){
        Debug.Log("lmao does it look like we have options hahaha you idiot");
    }
}
