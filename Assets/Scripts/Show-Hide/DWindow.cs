using UnityEngine;
using UnityEngine.SceneManagement;

public class DWindow : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))


        {
            SceneManager.LoadScene("Level2_2DWindow");
        }

        {
            if (Input.GetKeyDown(KeyCode.B))


            {
                SceneManager.LoadScene("Level2_2DWindow");
            }
        }
    }
}
    
    