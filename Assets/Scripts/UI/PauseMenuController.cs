using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
	[SerializeField]
	private GameObject pauseMenu;

	public void PauseGame()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
	}


	public void ResumeGame()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;

		try
		{
			GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().ResumeGame();
		}
		catch (Exception e) { Debug.Log(e); }
	}
}
