using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public Color TeamColor;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        instance = this;

        DontDestroyOnLoad(gameObject);

        LoadColor();
    }

    public void SaveColor()
    {
        SaveData data = new SaveData();
        data.teamColor = TeamColor;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/saveFile.json", json);
    }

    public void LoadColor()
    {
        TeamColor = JsonUtility.FromJson<SaveData>(File.ReadAllText(Application.persistentDataPath + "/saveFile.json")).teamColor;
    }


    [System.Serializable]
    class SaveData
    {
        public Color teamColor;
    }
}
