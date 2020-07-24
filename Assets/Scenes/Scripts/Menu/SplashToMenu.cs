using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(SceneChange());
	}
	
	

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(19.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
