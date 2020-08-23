using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urlbutton : MonoBehaviour {

            public void OpenURL()
        {
            Application.OpenURL("http://seriousgames.ie/gamesurvey/");
            Debug.Log("Survey");
        }

    }