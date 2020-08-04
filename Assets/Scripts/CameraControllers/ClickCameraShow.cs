using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCameraShow : MonoBehaviour {

    [SerializeField] private Camera customCamera;

    void OnMouseDown()
    {
        customCamera.enabled = true;
    }
}