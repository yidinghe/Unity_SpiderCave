using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

	public void PlayGame ()
	{
		SceneManager.LoadScene ("GamePlay");
	}

	public void BackToMenu ()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
