using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
	public void QuitGame()
	{
		Application.Quit();
		Debug.Log("Quit!");
	}

	public void RestartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
	}
}
