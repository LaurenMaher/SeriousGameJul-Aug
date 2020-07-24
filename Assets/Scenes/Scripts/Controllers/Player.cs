using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text textScore = null;
	public static int score = 0;

	private void OnTriggerEnter(Collider hit)
	{
		if (hit.CompareTag("Food"))
		{
			Player.score++;
			Destroy(hit.gameObject);
		}
	}

	private void Update()
	{
        //		print("Score: " + Player.score);
        textScore.text = "Score = " + score;
   }
}

