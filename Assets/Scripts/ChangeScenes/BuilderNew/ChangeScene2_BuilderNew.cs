using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene2_BuilderNew : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2Sittingroom_LM");
    }
}
