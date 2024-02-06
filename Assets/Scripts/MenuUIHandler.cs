using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public ColorPicker ColorPicker;
    
    public void SaveColors()
    {
        MainManager.instance.SaveColor();
    }

    public void LoadColors()
    {
        MainManager.instance.LoadColor();
        ColorPicker.SelectColor(MainManager.instance.TeamColor);
    }

    public void Quit()
    {
        MainManager.instance.SaveColor();

        #if UNITY_EDITOR
        
        EditorApplication.EnterPlaymode();
        
        #else

        Application.Quit();

        #endif
    }

    public void NewColorSelected(Color color)
    {
        MainManager.instance.TeamColor = color;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    private void Start()
    {
        ColorPicker.Init();
        //this will call the NewColorSelected function when the color picker have a color button clicked.
        ColorPicker.onColorChanged += NewColorSelected;

        ColorPicker.SelectColor(MainManager.instance.TeamColor);
    }
}
