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
        for (int i = 0; i < unlockedLevel && i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void CompleteLevel(int level)
    {
        // Get the current unlocked level from PlayerPrefs, defaulting to 1 if not set
        int unlockedLevel = PlayerPrefs.GetInt("unlockedLevel", 1);
        
        // If the completed level is equal to the current unlocked level
        if (level == unlockedLevel)
        {
            // Update the unlocked level to the next level
            PlayerPrefs.SetInt("unlockedLevel", level + 1);
            // Save the changes to PlayerPrefs
            PlayerPrefs.Save();
        }
    }
    public void unlockedNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();  
        }
    }

}
