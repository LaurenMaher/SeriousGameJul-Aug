using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BacktoMenu : MonoBehaviour
{
    void Start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}