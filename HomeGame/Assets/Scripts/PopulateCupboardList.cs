using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateCupboardList : MonoBehaviour
{
    public CookingMain CookingMain;
    public GameObject ItemTemplate;

    void Start()
	{
		ItemTemplate.SetActive(false);
		MakeButtons();
    }

	private List<GameObject> m_items = new List<GameObject>();

    private void MakeButtons()
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
			newItem.transform.localPosition = new Vector3(0, i*-20, 0);
			newItem.SetActive(true);
			m_items.Add(newItem);

			Text text = newItem.GetComponentInChildren<Text>();
            text.text = CookingMain.GetIngredientName(ingredient, true);
            newItem.name = text.text;

			Button button = newItem.GetComponent<Button>();
			button.onClick.AddListener(delegate { OnCupboardItemSelected(ingredient); });

        }
    }

	void OnCupboardItemSelected(IngredientType ingredient)
	{
		CookingMain.AddToStew(ingredient);
		CookingMain.CupboardList.Remove(ingredient);

		MakeButtons(); // Reset the button list without the selected item
	}
}
