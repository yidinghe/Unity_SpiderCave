﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderJumper : MonoBehaviour
{

	public float forceY = 300f;

	private Rigidbody2D myBody;
	private Animator anim;

	void Awake ()
	{
		InitializeVariables ();
	}

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (Attack ());
	}

	void InitializeVariables ()
	{
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	IEnumerator Attack ()
	{
		yield return new WaitForSeconds (Random.Range (2, 7));

		forceY = Random.Range (250, 550);

		myBody.AddForce (new Vector2(0, forceY));
		anim.SetBool ("Attack", true);

		yield return new WaitForSeconds (.7f);
		StartCoroutine (Attack ());
	}

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Ground") {
			anim.SetBool ("Attack", false);
		}
		if (target.tag == "Player") {
			Destroy (target.gameObject);
			GameObject.Find ("GamePlay Controller").GetComponent<GamePlayController> ().PlayerDied ();
		}
	}
}
