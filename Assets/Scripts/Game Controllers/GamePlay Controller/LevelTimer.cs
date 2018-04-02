using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{

	private Slider slider;
	private GameObject player;
	public float maxTime = 100f;
	[HideInInspector]
	public float time = 100f;

	public float timeBurn = 1f;

	void Awake ()
	{
		GetReferences ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!player)
			return;
		if (time > 0) {
			if (time > maxTime)
				time = maxTime;
			time -= timeBurn * Time.deltaTime;
			slider.value = time;
		} else {
			GetComponent<GamePlayController> ().PlayerDied ();
			Destroy (player);
		}
	}

	void GetReferences ()
	{
		player = GameObject.Find ("Player");
		slider = GameObject.Find ("Time Slider").GetComponent<Slider> ();

		time = maxTime;
		slider.minValue = 0f;
		slider.maxValue = time;
		slider.value = slider.maxValue;
	}
}
