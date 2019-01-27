using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearVIDEDataOnStart : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.DeleteAll();
        if (System.IO.Directory.Exists(Application.dataPath + "/VIDE/saves"))
        {
            System.IO.Directory.Delete(Application.dataPath + "/VIDE/saves", true);
            #if UNITY_EDITOR
                 UnityEditor.AssetDatabase.Refresh();
            #endif
        }
    }
}
