using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneCavity : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3Cavity 1");
    }
}