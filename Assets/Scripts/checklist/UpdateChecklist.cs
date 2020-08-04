using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateChecklist : MonoBehaviour
{
    private Checklist checklist;

    private void Start()
    {
        checklist = GetComponent<Checklist>();
    }

    public void CheckIfMatch(string tag)
    {
        switch (tag)
        {
            case "ISSUE_INSULATION":
                checklist.issue1Insulation = true;
                break;

            case "ISSUE_GAPS":
                checklist.issue2Gaps = true;
                break;

            case "ISSUE_MOULD":
                checklist.issue3Mould = true;
                break;


            default:
                // do nothing;
                break;
        }

        checklist.ShowList();
    }


}
