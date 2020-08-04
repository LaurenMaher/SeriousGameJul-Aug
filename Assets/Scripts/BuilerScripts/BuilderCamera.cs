using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuilderCamera : MonoBehaviour
{

    [SerializeField] private Camera customCamera;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            customCamera.enabled = true;

        }
    }
    
}