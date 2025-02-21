using UnityEngine;
using UnityEngine.SceneManagement;

public class unLock : MonoBehaviour
{
    public void UnlockLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("unlockedLevel", PlayerPrefs.GetInt("unlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }
}