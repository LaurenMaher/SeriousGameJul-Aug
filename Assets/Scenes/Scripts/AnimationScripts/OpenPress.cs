using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPress : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            anim.SetBool("OpenPress", true);
            anim.SetBool("OpenPress2", true);
        }
    if (Input.GetKey(KeyCode.P))
        {
            anim.SetBool("OpenPress", false);
            anim.SetBool("OpenPress2", false);
        }
    }
}

