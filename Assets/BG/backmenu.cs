using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backmenu : MonoBehaviour
{
    public Canvas start;
    public Button Exit;

    public void back()
    {
        SceneManager.LoadScene("menu");
    }
}
