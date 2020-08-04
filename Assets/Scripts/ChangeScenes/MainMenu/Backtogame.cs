using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtogame : MonoBehaviour
{

	
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene("Quiz");
        }

        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene("Level2");
        }

        if (Input.GetKey(KeyCode.G))
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
