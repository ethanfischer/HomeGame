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
        foreach (var ingredient in cupboard)
        {
            var newItem = Instantiate(ItemTemplate, new Vector3(0, 20, 0), Quaternion.identity, ItemTemplate.transform.parent);




        }

        ItemTemplate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
