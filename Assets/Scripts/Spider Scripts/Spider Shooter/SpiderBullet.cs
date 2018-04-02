using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBullet : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D target)
	{	
		if (target.tag == "Player") {
			Destroy (target.gameObject);
			Destroy (gameObject);
			GameObject.Find ("GamePlay Controller").GetComponent<GamePlayController> ().PlayerDied ();
		}

		if (target.tag == "Ground") {
			Destroy (gameObject);
		}

	}

}
