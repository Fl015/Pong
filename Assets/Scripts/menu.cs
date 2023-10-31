using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void OnSingleButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnMultiButton ()
    {
        SceneManager.LoadScene(2);
    }
    
    public void OnQuitButton ()
    {
        Application.Quit();
    }
}
