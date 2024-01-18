using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using System.IO;
using System;

public class sceneSaving : MonoBehaviour
{
    public Text text;
    public static string name;

    public static int score;

    public static void saveGame()
    {
        Debug.Log(score);

        File.WriteAllText(Application.persistentDataPath + "/data.rsu", score.ToString());
    }
    private float loadScore()
    {
        if (File.Exists(Application.persistentDataPath + "/data.rsu"))
        {
            return float.Parse(File.ReadAllText(Application.persistentDataPath + "/data.rsu"));
        }
        return 0;
    }


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        text.text = name;
        text.text = $"Name: {name}, current Highscore: {loadScore()}";
    }
}
