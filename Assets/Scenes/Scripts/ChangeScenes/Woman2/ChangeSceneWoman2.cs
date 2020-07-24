using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWoman2 : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}