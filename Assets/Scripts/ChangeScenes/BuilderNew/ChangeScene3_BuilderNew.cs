using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene3_BuilderNew : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3Cavity1_newTest");
    }
}