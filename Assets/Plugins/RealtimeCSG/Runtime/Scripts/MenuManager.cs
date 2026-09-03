using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // 1. Function for the Play Button
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // 2. Function for the Settings Button (e.g., opens a settings panel)
    public void OpenSettings()
    {
        Debug.Log("Settings Opened!");
        // You can toggle a settings panel object here later!
    }

    // 3. Function for the Quit Button
    public void QuitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
    }
}