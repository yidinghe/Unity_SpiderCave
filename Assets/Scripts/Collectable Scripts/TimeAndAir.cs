using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeAndAir : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Player") {
			if (gameObject.name == "Air") {
				GameObject.Find ("GamePlay Controller").GetComponent<AirTimer> ().air += 15f;
				Destroy (gameObject);
			} else if (gameObject.name == "Time") {
				GameObject.Find ("GamePlay Controller").GetComponent<LevelTimer> ().time += 15f;
				Destroy (gameObject);
			}
		}
	}
}
