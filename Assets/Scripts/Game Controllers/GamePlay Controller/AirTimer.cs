using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirTimer : MonoBehaviour {

	private Slider slider;
	private GameObject player;
	public float maxAir = 100f;
	[HideInInspector]
	public float air = 100f;
	public float airBurn = 1f;

	void Awake ()
	{
		GetReferences ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (!player)
			return;
		if (air > 0) {
			if (air > maxAir)
				air = maxAir;
			air -= airBurn * Time.deltaTime;
			slider.value = air;
		} else {
			GetComponent<GamePlayController> ().PlayerDied ();
			Destroy (player);
		}
	}

	void GetReferences ()
	{
		player = GameObject.Find ("Player");
		slider = GameObject.Find ("Air Slider").GetComponent<Slider> ();

		air = maxAir;
		slider.minValue = 0f;
		slider.maxValue = air;
		slider.value = slider.maxValue;
	}
}
