using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class L1 : MonoBehaviour
{   
    public float sec;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(LoadNextScene());
    }

    private IEnumerator LoadNextScene()
    {
        // Wait for seconds
        yield return new WaitForSeconds(sec);
        
        // Load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
