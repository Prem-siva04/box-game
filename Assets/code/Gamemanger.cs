using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool gamedone = false;
    public GameObject inst;
    public GameObject Rule;
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
     if (gamedone == false)
        {
            gamedone = true;
            Debug.Log("Game over");
            restart();
         }
    }
    public void instruction(){
        inst.SetActive(true);
    }
    public void NoInstruction(){
        inst.SetActive(false);
    }
    public void rule(){
        Rule.SetActive(true);
    }
    public void ComRule(){
        Rule.SetActive(false);
    }
}
