using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
// opens the maze scene in the game
    public void PlayGame ()
    {
        SceneManager.LoadScene("Maze");
    }
    
    // closes the game
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
