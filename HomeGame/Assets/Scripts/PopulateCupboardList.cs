﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateCupboardList : MonoBehaviour
{
    public CookingMain CookingMain;
    public GameObject ItemTemplate;
	public Sprite[] Icons;
	public Image FoodIcon;
	public Sprite emptySprite;

    void Start()
	{
		ItemTemplate.SetActive(false);
		MakeButtons();
    }

	private List<GameObject> m_items = new List<GameObject>();

    public void MakeButtons()
    {
		foreach (GameObject item in m_items)
		{
			Destroy(item);
		}
		m_items.Clear();

        var cupboard = CookingMain.CupboardList;
        for (int i = 0; i < cupboard.Count; i++)
        {
            IngredientType ingredient = cupboard[i];
            GameObject newItem = Instantiate(ItemTemplate,  ItemTemplate.transform.parent);
			newItem.SetActive(true);
			m_items.Add(newItem);

			Text text = newItem.GetComponentInChildren<Text>();
            text.text = CookingMain.GetIngredientName(ingredient, true);
            newItem.name = text.text;

			Button button = newItem.GetComponent<Button>();
			button.onClick.AddListener(delegate { OnCupboardItemSelected(ingredient); });

			ButtonHoverer hover = newItem.AddComponent<ButtonHoverer>();
			hover.Icon = Icons[(int)ingredient];
			hover.TargetImage = FoodIcon;
        }

		FoodIcon.sprite = emptySprite;
    }

	void OnCupboardItemSelected(IngredientType ingredient)
	{
		CookingMain.AddToStew(ingredient);
		CookingMain.CupboardList.Remove(ingredient);

        SceneManager.Instance.IncrementScene();
        MakeButtons(); // Reset the button list without the selected item
    }
}
