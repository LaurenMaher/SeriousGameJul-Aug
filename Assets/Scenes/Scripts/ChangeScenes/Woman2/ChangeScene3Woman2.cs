using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene3Woman2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3Cavity_Woman2");
    }
}