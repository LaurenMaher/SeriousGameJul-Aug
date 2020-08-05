using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{

    private static DontDestroy instance;
    void Start()
    {
        if (instance == null) // This is first object, set the static reference
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }

    }
}