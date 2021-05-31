using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class backguid : MonoBehaviour
{
    public Canvas start;
    public Button Exit;

    public void back()
    {
        SceneManager.LoadScene("menu");
    }
}