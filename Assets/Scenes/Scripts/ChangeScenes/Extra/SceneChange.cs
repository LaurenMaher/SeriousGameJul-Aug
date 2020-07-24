using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class SceneChange : MonoBehaviour
{

    public int num;

    // Use this for initialization
    void Update()
    {
       if (Input.GetKey(KeyCode.Y))
        {
            SceneManager.LoadScene(num);
            Debug.Log("Scene changed to " + num);
        }
    }
}