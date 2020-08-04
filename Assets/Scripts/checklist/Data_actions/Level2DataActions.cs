using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2DataActions : MonoBehaviour {

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("SittingRoom"))
        {
            LogSittingRoomEnter();
        }
    }

    private void LogSittingRoomEnter()
    {
        string varName;

        // get start time
        varName = "DataScreen1_StartTime";
        float startTime = PlayerPrefs.GetFloat(varName);

        varName = "SittingRoomEnter_Time";
        float secondsSinceStart = Time.time - startTime;
        PlayerPrefs.SetFloat(varName, secondsSinceStart);

        print("just stored in PlayerPrefs: " + varName + " = " + secondsSinceStart);
    }


}
