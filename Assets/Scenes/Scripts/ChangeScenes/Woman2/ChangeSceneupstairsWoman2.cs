using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneupstairsWoman2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level5_UPStairs_Woman2");
    }
}