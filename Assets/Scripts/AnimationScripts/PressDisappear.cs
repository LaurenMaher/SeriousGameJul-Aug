using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressDisappear : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            anim.SetBool("PressDisappear", true);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            anim.SetBool("PressDisappear", false);
          
        }
    }
}


