﻿using UnityEngine;

public class Door4 : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Door4", true);

    }
}