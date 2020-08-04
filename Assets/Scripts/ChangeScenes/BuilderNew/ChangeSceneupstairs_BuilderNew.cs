using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneupstairs_BuilderNew : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level5_UPStairs_newTest");
    }
}