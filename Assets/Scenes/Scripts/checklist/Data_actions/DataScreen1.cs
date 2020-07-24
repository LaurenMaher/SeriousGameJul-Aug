using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataScreen1 : MonoBehaviour {

    public Text textPlayerName;

    public void BUTTON_ACTION_SavePlayerName()
    {
        string playerName = textPlayerName.text;
        string varName = "PlayerName";
        PlayerPrefs.SetString(varName, playerName);
        float timeStart = Time.time;
        varName = "DataScreen1_StartTime";
        PlayerPrefs.SetFloat(varName, timeStart);
    }

    public void BUTTON_ACTION_OuputData()
    {
        BUTTON_ACTION_SavePlayerName();
        SceneManager.LoadScene("data_screenFINAL");
    }
}
