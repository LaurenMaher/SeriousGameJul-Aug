using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene4Woman1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SplashScreen");
    }
}
