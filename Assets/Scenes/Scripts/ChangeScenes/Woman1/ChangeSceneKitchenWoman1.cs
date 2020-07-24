using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ChangeSceneKitchenWoman1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level4Kitchen_Woman");
    }
}