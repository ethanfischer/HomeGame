using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ShowCupboard : MonoBehaviour
{
    public GameObject CupboardUI;

    public void ShowIt()
    {
        CupboardUI.SetActive(true);
        gameObject.SetActive(false);
    }
}
