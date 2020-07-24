using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene3Man2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3Cavity_Man2");
    }
}