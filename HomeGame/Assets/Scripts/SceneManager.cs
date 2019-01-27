using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Persistence;

public class SceneManager : MonoBehaviour
{
    private static SceneManager _sceneManager;

    public static SceneManager Instance
    {
        get
        {
            if (_sceneManager == null)
            {
                _sceneManager = GameObject.FindObjectOfType<SceneManager>();
            }

            return _sceneManager;
        }
    }

    private int m_sceneIndex = 0;
    public int SceneIndex { get { return m_sceneIndex; } }
    public GameObject CupboardButton;
    public GameObject CupboardUI;
    public Template_UIManager UIManager;
    public CookingMain CookingMain;
    public GameObject ParticleSystem;
    public GameObject PotLid;
    public GameObject PotLidOpen;


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
                CupboardUI.SetActive(false);
                UIManager.textReplaceIngredient = CookingMain.LastStewIngredient();
                break;
            case 3:
                CupboardButton.SetActive(true);
                break;
            case 4:
                CupboardUI.SetActive(false);
                UIManager.textReplaceIngredient = CookingMain.LastStewIngredient();
                break;
			case 5:
                PotLid.SetActive(false);
                PotLidOpen.SetActive(true);
                ParticleSystem.SetActive(true);
				UIManager.stewScore = CookingMain.StewScore();
				UIManager.textReplaceIngredient = CookingMain.RandomStewIngredient();
				break;
            default:
                break;
        }
    }
}
