using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneCavityBuilder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3Cavity2_newTest");
    }
}