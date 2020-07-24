using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveUN : MonoBehaviour
{

    public GameObject Cube;



    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            Cube.SetActive(false);

        }

        else if (Input.GetKey(KeyCode.R))
        {
            Cube.SetActive(true);

        }
    }
}