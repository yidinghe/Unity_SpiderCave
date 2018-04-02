using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	private PlayerScript player;

	void Awake ()
	{
		player = GameObject.Find ("Player").GetComponent<PlayerScript> ();
	}

	public void OnPointerDown (PointerEventData data)
	{
		if (gameObject.name == "Left") {
			if (player != null) {
				player.SetMoveLeft (true);
			}
		} else if (gameObject.name == "Right") {
			if (player != null) {
				player.SetMoveLeft (false);
			}
		}
	}

	public void OnPointerUp (PointerEventData data)
	{
		if (gameObject.name == "Left") {
			if (player != null) {
				player.StopMove ();
			}
		} else if (gameObject.name == "Right") {
			if (player != null) {
				player.StopMove ();
			}
		}
	}
}
