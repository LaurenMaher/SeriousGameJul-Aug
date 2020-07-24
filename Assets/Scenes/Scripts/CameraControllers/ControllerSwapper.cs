using UnityEngine;
using UnityEngine.UI;

public class ControllerSwapper : MonoBehaviour {
    public GameObject firstPersonControllerObject;
    public GameObject thirdPersonControllerObject;
    public GameObject thirdPersonCameraControllerObject;

    private bool thirdPersonMode = true;
    private float timeBetweenChanges = 0.2f;
    private float nextTimeToCheckForChange = 0;

    private Text myButton;

    private void Start()
    {
        myButton = GameObject.FindGameObjectWithTag("Respawn").GetComponent<Text>();
        EnableDisableBasedOnMode();
    }

    private void Update()
    {
        if (AllowedToChange())
        {
            if (Input.GetKey(KeyCode.C))
            {
                thirdPersonMode = !thirdPersonMode;
                MoveNewControllerToOldControllerPosition();
                nextTimeToCheckForChange = Time.time + timeBetweenChanges;
                EnableDisableBasedOnMode();
            }
        }

        myButton.text = "FPS rotation = " + firstPersonControllerObject.transform.rotation.ToEuler();
    }

    /// <summary>
    /// move new controller to position of old controller
    /// </summary>
    private void MoveNewControllerToOldControllerPosition()
    {
        if (thirdPersonMode)
        {
            Vector3 thirdPersonCameraOffset =  thirdPersonControllerObject.transform.position - thirdPersonCameraControllerObject.transform.position;

            thirdPersonControllerObject.transform.position = firstPersonControllerObject.transform.position;
            thirdPersonCameraControllerObject.transform.rotation = firstPersonControllerObject.transform.rotation;
            thirdPersonCameraControllerObject.transform.position = thirdPersonControllerObject.transform.position + thirdPersonCameraOffset;
        } else
        {
            firstPersonControllerObject.transform.position = thirdPersonControllerObject.transform.position;
            firstPersonControllerObject.transform.rotation = thirdPersonControllerObject.transform.rotation;
        }
    }

    private bool AllowedToChange()
    {
        return Time.time > nextTimeToCheckForChange;
    }

    private void EnableDisableBasedOnMode()
    {
        thirdPersonControllerObject.SetActive(thirdPersonMode);
        thirdPersonCameraControllerObject.SetActive(thirdPersonMode);
        firstPersonControllerObject.SetActive(!thirdPersonMode);
    }

}
