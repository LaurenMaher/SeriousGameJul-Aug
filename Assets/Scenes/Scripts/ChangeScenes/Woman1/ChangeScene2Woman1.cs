using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene2Woman1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2SittingRoom_Woman");
    }
}
