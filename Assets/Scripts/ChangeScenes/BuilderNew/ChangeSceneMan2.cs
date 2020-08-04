using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMan2 : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}