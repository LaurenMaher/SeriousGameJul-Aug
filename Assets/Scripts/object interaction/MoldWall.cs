using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoldWall : MonoBehaviour
{

    public GameObject UpstairsWall;



    void Update()
    {

        if (Input.GetKey(KeyCode.T))
        {
            UpstairsWall.SetActive(false);

        }

        else if (Input.GetKey(KeyCode.K))
        {
            UpstairsWall.SetActive(true);

        }
    }
}