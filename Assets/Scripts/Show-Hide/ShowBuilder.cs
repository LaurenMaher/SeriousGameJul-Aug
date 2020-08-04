using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBuilder : MonoBehaviour
{

    [SerializeField] private GameObject BuilderHelp1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BuilderHelp1.SetActive(true);


        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            BuilderHelp1.SetActive(false);

        }
    }
}