using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void PlayGame ()
    {
        //Need to add "Game" scene to build settings in unity after the 'MainMenu' for this to function, waiting on game creation
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        //Logging Quit Game for Unity Console
        Debug.Log("Game Quit");
        Application.Quit();
    }

}
