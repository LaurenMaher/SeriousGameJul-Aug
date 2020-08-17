﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmalcom : MonoBehaviour {

    Animator anim;

    // Use this for initialization
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("Walk");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.enabled = true;
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
