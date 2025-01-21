using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnStart()
    {
        SceneManager.LoadScene(1); //scene 1 is the second scene, this loads the level
    }

    public void OnQuit()
    {
        Application.Quit(); //bye bye
    }
}
