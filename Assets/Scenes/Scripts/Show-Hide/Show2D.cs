using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show2D : MonoBehaviour
{

    [SerializeField] private Image customImage;


    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            customImage.enabled = true;
        }
        {
            if (Input.GetKeyDown("3"))
            {
                customImage.enabled = false;
            }
        }
    }
}