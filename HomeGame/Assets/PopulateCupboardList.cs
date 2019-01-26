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
        for (var i = 0; i < cupboard.Count; i++)
        {
            var ingredient = cupboard[i];
            var newItem = Instantiate(ItemTemplate,  ItemTemplate.transform.parent);
            newItem.transform.localPosition = new Vector3(0, i*-20, 0);
            var text = newItem.GetComponentInChildren<Text>();
            text.text = CookingMain.GetIngredientName(ingredient, true);
            newItem.name = text.text;
        }

        ItemTemplate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
