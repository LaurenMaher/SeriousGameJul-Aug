using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{

    //in the class:

    void OnMouseUp()
    {
        SceneManager.LoadScene("GameOver");
    }
}