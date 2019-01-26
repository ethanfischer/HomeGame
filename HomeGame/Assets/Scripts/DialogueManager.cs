using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
	public VIDE_Assign[] Dialogues;
	public Template_UIManager UIManager;
	public SceneManager SceneManager;

	public void DoDialogue()
	{
		int index = SceneManager.SceneIndex;

		UIManager.Interact(Dialogues[index]);
	}
}
