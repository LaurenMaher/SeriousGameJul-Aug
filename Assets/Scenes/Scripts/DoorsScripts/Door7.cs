using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door7 : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Door7", true);

    }

  
}
