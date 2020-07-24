using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneCavityWoman1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3Cavity 1_Woman1");
    }
}