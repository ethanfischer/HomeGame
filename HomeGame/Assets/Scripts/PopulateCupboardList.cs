using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateCupboardList : MonoBehaviour
{
    public CookingMain CookingMain;
    public GameObject ItemTemplate;

    // Start is called before the first frame update
    void Start()
    {
        MakeButtons();
    }

    private void MakeButtons()
    {
        var cupboard = CookingMain.CupboardList;
        for (int i = 0; i < cupboard.Count; i++)
        {
            IngredientType ingredient = cupboard[i];
            var newItem = Instantiate(ItemTemplate,  ItemTemplate.transform.parent);
            newItem.transform.localPosition = new Vector3(0, i*-20, 0);
            var text = newItem.GetComponentInChildren<Text>();
            text.text = CookingMain.GetIngredientName(ingredient, true);
            newItem.name = text.text;


			Button button = newItem.GetComponent<Button>();
			button.onClick.AddListener(delegate { OnCupboardItemSelected(ingredient); });
        }

        ItemTemplate.SetActive(false);
    }

	void OnCupboardItemSelected(IngredientType ingredient)
	{
		CookingMain.AddToStew(ingredient);
        Debug.Log("oncupboardsdfjlskj");
	}
}
