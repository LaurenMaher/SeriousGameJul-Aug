using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Builder1 : MonoBehaviour
{


    [SerializeField] private Camera customCamera;

    void Update()
    {
        if (Input.GetKey(KeyCode.H))

        {

            customCamera.enabled = true;
        }
    }
}