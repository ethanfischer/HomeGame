using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
	public VIDE_Assign[] Dialogues;
	public Template_UIManager Manager;

	public void DoDialogue()
	{
		int index = 0;

		// Something that finds the proper index

		Manager.Interact(Dialogues[index]);
	}
}
