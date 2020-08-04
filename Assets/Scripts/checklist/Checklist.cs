using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Checklist : MonoBehaviour
{
    private Text textChecklist;
    public bool issue1Insulation = false;
    public bool issue2Gaps = false;
    public bool issue3Mould = false;

    private void Start()
    {
        textChecklist = GetComponent<Text>();
        ShowList();
    }

    public void ShowList()
    {
        string message = "";
        message += "\n (1) Insulation = " + issue1Insulation;
        message += "\n (2) Gaps = " + issue2Gaps;
        message += "\n (3) Mould = " + issue3Mould;

        textChecklist.text = message;
    }

}
