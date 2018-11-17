using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("The game has been shut down.");
    }
}
