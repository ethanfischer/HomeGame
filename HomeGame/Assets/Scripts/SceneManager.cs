using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
	private int m_sceneIndex = 0;
	public int SceneIndex { get { return m_sceneIndex; } }
    public GameObject CupboardButton;

	public void IncrementScene()
	{
		m_sceneIndex++;

		UpdateSceneObjects();
	}

	private void UpdateSceneObjects()
	{
		switch (m_sceneIndex)
		{
			case 0:
				break;
			case 1:
                CupboardButton.SetActive(true);
				break;
			case 2:
				break;
			default:
				break;
		}
	}
}
