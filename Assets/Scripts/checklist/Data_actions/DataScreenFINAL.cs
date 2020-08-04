using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataScreenFINAL : MonoBehaviour {

    private void Start()
    {
        string varName;

        varName = "PlayerName";
        string playerName = PlayerPrefs.GetString(varName);
        print(varName + " = " + playerName);

        varName = "DataScreen1_StartTime";
        float dataScreen1StartTime = PlayerPrefs.GetFloat(varName);
        print(varName + " = " + dataScreen1StartTime);

    }


}
