using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    //Singleton pattern so we can reference PlayerItems from any script
    private static PlayerItems _instance;
    public static PlayerItems Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<PlayerItems>();
            }

            return _instance;
        }
    }

    public List<GameObject> ItemsList = new List<GameObject>();

    void Start()
    {
    }

    void Update()
    {
        
    }

    public GameObject GetRandomItem()
    {
        var randomInt = new System.Random().Next(0, ItemsList.Count);
        return ItemsList[randomInt];
    }
}
