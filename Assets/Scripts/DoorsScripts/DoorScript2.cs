using UnityEngine;

public class DoorScript2 : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.enabled = true;
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("DoorSitRoom", true);
       
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("DoorSitRoom", false);
       
    }
}
