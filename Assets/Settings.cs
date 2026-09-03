using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject settingsPanel;
    public AudioMixer mainMixer;

    public void OpenSettings()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void SetVolume(float volume)
    {
        // Converts linear slider value (0.0001 to 1) to decibels (-80dB to 0dB)
        mainMixer.SetFloat("MasterVolume", Mathf.Log10(Mathf.Max(0.0001f, volume)) * 20);
    }
}