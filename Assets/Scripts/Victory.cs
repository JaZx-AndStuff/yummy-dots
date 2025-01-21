using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
   public void retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1); //scene 1 is the second scene in the build, meaning its refreashing the scene
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0); //scene 0 is the first, so its the menu
    }
}
