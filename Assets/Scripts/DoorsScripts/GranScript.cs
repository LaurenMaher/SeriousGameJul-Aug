using UnityEngine;

public class GranScript : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("SittingTalking", true);
       
    }


}
