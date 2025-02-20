using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class welcome : MonoBehaviour
{   
    public void StartGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void menuLevel() {
        SceneManager.LoadScene(2);
    }
    public void LevelOne(){
        SceneManager.LoadScene(3);
    }
    public void LOneRS(){
        SceneManager.LoadScene(3);
    }
    public void NRestart(){
        SceneManager.LoadScene(8);
    } 
        public void BackGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void LevelTwo() {
        SceneManager.LoadScene(9);
    }
}
