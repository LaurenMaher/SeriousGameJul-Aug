
using UnityEngine;
using UnityEngine.UI;

public class ShowTextPopup : MonoBehaviour
{
    public string message = "";
    public Text textToShow = null;
    public Image imageBg = null;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textToShow.text = message;
            imageBg.enabled = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textToShow.text = "";
            imageBg.enabled = false;
        }
    }



}
