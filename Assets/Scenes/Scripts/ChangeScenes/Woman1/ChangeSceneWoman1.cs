using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWoman1 : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}