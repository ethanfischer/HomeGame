using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StewPot : MonoBehaviour
{
	public Image Stew;
	public GameObject IngredientTemplate;
	public PopulateCupboardList IconHolder;

	public Color[] stewColors;

	public void DoProceduralStew(Stew stew)
	{
		Stew.color = stewColors[Random.Range(0, stewColors.Length)];

		for (int j=0; j<3; j++)
		{
			for (int i = 0; i < stew.Ingredients.Count; i++)
			{
				GameObject ing = Instantiate(IngredientTemplate, IngredientTemplate.transform.parent);
				ing.transform.localPosition = new Vector3(Random.Range(-45f, 45f), Random.Range(-6f, 5f));
				ing.transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360.0f));

				Image image = ing.GetComponent<Image>();
				image.sprite = IconHolder.Icons[(int)stew.Ingredients[i].Type];

				ing.SetActive(true);
			}
		}
	}
}
