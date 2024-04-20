using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_settings_0 : MonoBehaviour
{
    public GameObject SettingPanel, InstructionPanel, LevelPanel;

    public void SettingButtonPressed()
    {
        SettingPanel.SetActive(true);

    }

    public void FromSetToMenuButtonPressed()
    {
        SettingPanel.SetActive(false);
    }

    public void InstructionButtonPressed()
    {
        InstructionPanel.SetActive(true);

    }

    public void FromInstToMenuButtonPressed()
    {
        InstructionPanel.SetActive(false);
    }
    public void FromLevToMenuButtonPressed()
    {
        LevelPanel.SetActive(false);
    }

    public void StartButtonPressed()
    {
        LevelPanel.SetActive(true);
    }

    public void ExitButtonPressed()
    {
        Log_in.UserIn = false;
        Application.Quit();
    }
}
