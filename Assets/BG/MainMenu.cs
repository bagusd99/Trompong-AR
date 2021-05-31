using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void Back()
    {
        SceneManager.LoadScene("menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("ar");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void how()
    {
        SceneManager.LoadScene("How");
    }

    public void EXIT()
    {
        Application.Quit();
    }


}
