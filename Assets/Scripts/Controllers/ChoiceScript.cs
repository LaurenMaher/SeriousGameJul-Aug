using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ChoiceScript : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

