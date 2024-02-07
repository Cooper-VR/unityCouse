using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public static void ToGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
