using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveUN : MonoBehaviour
{
    public AudioSource GoOutside;
    public GameObject Cube;



    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            Cube.SetActive(false);
            GoOutside.Play();
        }

        else if (Input.GetKey(KeyCode.R))
        {
            Cube.SetActive(true);

        }
    }
}