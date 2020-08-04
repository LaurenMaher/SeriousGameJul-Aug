using UnityEngine;

public class Door3 : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Door3", true);
       
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("Door3", false);
       
    }
}
