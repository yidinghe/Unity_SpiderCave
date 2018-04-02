using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour
{

	[SerializeField]
	private GameObject pausePanel;

	[SerializeField]
	private Button resumeButton;

	public void PauseGame ()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeButton.onClick.RemoveAllListeners ();
		resumeButton.onClick.AddListener (() => ResumeGame ());
	}

	public void GoToMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainMenu");
	}

	public void GoToSelectLevel()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("LevelMenu");
	}

	public void ResumeGame ()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void RestartGame ()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("GamePlay");
	}

	public void PlayerDied ()
	{
		Debug.Log ("PlayerDied");
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeButton.onClick.RemoveAllListeners ();
		resumeButton.onClick.AddListener (() => RestartGame ());
	}
}
