using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneupstairsMan2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level5_UPStairs_Man2");
    }
}