using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 
    public void Credits()
    {
        SceneManager.LoadScene(4);
    }
    public void How2Play()
    {
        SceneManager.LoadScene(5);
    }
    public void Back2Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
