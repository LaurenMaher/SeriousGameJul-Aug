using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWasher : MonoBehaviour {

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
            anim.SetBool("Machine", true);
        
        }
     
 
        if (Input.GetKey(KeyCode.P))
        {
            anim.SetBool("Machine", false);
            
        }
    }
}

