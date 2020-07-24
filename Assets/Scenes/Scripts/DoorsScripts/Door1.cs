using UnityEngine;

public class Door1 : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Door1", true);
       
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("Door1", false);
       
    }
}
