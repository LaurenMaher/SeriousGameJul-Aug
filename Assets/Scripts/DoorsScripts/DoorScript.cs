using UnityEngine;

public class DoorScript : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("OpenDoor", true);
       
    }


}
