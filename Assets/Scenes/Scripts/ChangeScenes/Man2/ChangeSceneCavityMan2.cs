using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneCavityMan2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3Cavity 1_Man2");
    }
}