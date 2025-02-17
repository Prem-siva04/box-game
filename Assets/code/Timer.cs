using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Text STimer;
    public float maxMinutes = 0.5f; // Set the maximum time limit to 30 seconds
    private float elapsedTime = 0f;
    private bool isRunning = false;

    private Gamemanger Gm;

    void Start()
    {
        ResetTimer();
        StartTimer(); // Start the timer when the game starts
    }

    void Update()
    {   
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerDisplay();

            // Stop the timer if it exceeds the maximum limit
            if (elapsedTime >= maxMinutes * 60) // Convert minutes to seconds
            {
                StopTimer();
                SceneManager.LoadScene(7);
            }
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        elapsedTime = 0f;
        UpdateTimerDisplay();
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 100) % 100);
        STimer.text = minutes.ToString() + ":" + seconds.ToString();
    }
}
