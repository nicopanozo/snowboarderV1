using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void PlayGame ()
    {
        //loading the next scene in the queue
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  + 1);
    }
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
