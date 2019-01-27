using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;

public class ChefManager : DialogueManager
{
	public PopulateCupboardList CupboardList;

    public void JumpToNextNode()
    {
        switch (SceneManager.SceneIndex)
        {
            case 0:
                break;

            case 1:
                VD.SetNode(1);
                break;
        }

    }

    public override void ResetInteractionCount()
    {
        base.ResetInteractionCount();
    }

	public void PickAnItemForTheStew()
	{
		IngredientType picked = CookingMain.CupboardList[Random.Range(0, CookingMain.CupboardList.Count)];
		CookingMain.AddToStew(picked);
		UIManager.textReplaceIngredient = picked;

		CookingMain.CupboardList.Remove(picked);
		CupboardList.MakeButtons();
	}
}
