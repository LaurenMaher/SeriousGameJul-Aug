using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{

    [SerializeField] private Button custombutton;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            custombutton.enabled = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            custombutton.enabled = false;

        }
    }
}
