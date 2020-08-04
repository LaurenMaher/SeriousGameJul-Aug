using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {


    //in the class:

    public void PlayGame()
    {
        SceneManager.LoadScene("Quiz");
    }
}