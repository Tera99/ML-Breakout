﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	// loads level select scene
	public void level01()
	{
		SceneManager.LoadScene("Versus 02");
	}

	public void level02()
	{
		SceneManager.LoadScene("Versus 02");
	}

	public void level03()
	{
		SceneManager.LoadScene("Versus 02");
	}



	// exits game
	public void Quit()
	{
		// close application when run from executable
		Application.Quit();

		// close down editor when running from editor
		//UnityEditor.EditorApplication.isPlaying = false;
	}
}
