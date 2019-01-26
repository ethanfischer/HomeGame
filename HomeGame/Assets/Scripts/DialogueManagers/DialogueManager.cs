using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;

public class DialogueManager : MonoBehaviour
{
	public VIDE_Assign[] Dialogues;
	public Template_UIManager UIManager;
	public SceneManager SceneManager;
    public CookingMain CookingMain;

	public virtual void DoDialogue()
	{
		UIManager.Interact(CurrentDialogue());
	}

    protected virtual VIDE_Assign CurrentDialogue()
    {
        int index = SceneManager.SceneIndex;
        return Dialogues[index];
    }

    public virtual void ResetInteractionCount()
    {
        VD.assigned.interactionCount = -1;
    }
}
