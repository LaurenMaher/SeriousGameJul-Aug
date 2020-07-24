using UnityEngine;

public class MouseDownAction : MonoBehaviour 
{
    public UpdateChecklist updateCheckList;


    void OnMouseDown()
    {
        updateCheckList.CheckIfMatch(gameObject.tag);
        
    }
}
