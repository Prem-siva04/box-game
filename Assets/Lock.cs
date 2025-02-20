using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lock : MonoBehaviour
{
    public Button[] buttons;

    private void Awake()
    {
        int unlockedLevel = PlayerPrefs.GetInt("unlockedLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            
        }
        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void CompleteLevel(int level)
    {
        int unlockedLevel = PlayerPrefs.GetInt("unlockedLevel", 1);
        if (level >= unlockedLevel)
        {
            PlayerPrefs.SetInt("unlockedLevel", level + 1);
            PlayerPrefs.Save();
        }
    }
}
