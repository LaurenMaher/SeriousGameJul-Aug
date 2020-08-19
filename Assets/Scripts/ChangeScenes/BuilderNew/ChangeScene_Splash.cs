using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene_Splash : MonoBehaviour
{
    void Start()
    
        {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
}