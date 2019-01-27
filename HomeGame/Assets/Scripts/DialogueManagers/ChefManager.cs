using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;

public class ChefManager : DialogueManager
{
    public void JumpToNextNode()
    {
        switch (SceneManager.SceneIndex)
        {
            case 0:
                break;

            case 1:
				if (AreScene1ConditionsMet())
				{
					VD.SetNode(2);
					UIManager.textReplaceIngredient = CookingMain.LastStewIngredient();
				}
				VD.SetNode(1);
				break;
        }

    }

    private bool AreScene1ConditionsMet()
    {
        if (CookingMain.LastStewIngredient() != IngredientType.NONE)
        {
            return true;
        }

        return false;
    }

    public override void ResetInteractionCount()
    {
        base.ResetInteractionCount();
    }
}
