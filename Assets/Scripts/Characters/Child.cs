using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Child : MonoBehaviour
{


    [SerializeField] private Image customImage;
    [SerializeField] private Text customText;
    [SerializeField] private Camera customCamera;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.enabled = true;
            customText.enabled = true;
            customCamera.enabled = true;


        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customImage.enabled = false;
            customText.enabled = false;
            customCamera.enabled = false;
        }
    }
}