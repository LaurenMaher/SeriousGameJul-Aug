using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeScene1_Opening : MonoBehaviour
{
    void Start()
    
        {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1Outside_ newTest");
    }
}