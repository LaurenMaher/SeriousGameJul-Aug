﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class LogAction_OptionFoam : MonoBehaviour
{

  

    private SendToWebLog logSender;
    public void Start()
    {
        logSender = GameObject.Find("logsender").GetComponent<SendToWebLog>();
    }

    

    public void BUTTON_ACTION_LogTextToFile()
    {
       
        logSender.LogLine("Fix with spray foam option clicked");
    }
    

}


