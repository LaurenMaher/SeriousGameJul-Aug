using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active2 : MonoBehaviour {

    public GameObject Cube2;



    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Cube2.SetActive(false);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            Cube2.SetActive(true);
        }

    }
}
