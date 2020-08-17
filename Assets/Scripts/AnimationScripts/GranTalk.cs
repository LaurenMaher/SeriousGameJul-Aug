using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranTalk : MonoBehaviour {

    Animator anim;
   

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnMouseDown()
    {
   
        {
            anim.SetBool("Sitting Talking", true);
        
        }
     
    }
}


