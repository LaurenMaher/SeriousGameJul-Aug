using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene2Man2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2SittingRoom_Man2");
    }
}
