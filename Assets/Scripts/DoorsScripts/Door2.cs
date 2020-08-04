using UnityEngine;

public class Door2 : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Door2", true);
       
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("Door2", false);
       
    }
}
