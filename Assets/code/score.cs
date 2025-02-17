using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Boxcollision boxCollision; // Reference to Boxcollision
    public int scorenum = 0;
    public Text scoreText; // Reference to the UI Text component
    public Gamemanger man;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

      
    // Update is called once per frame
    void Update()
    {    
        // Check if the player has collided with the box
        if (scorenum < boxCollision.boxCount - 1)
        {
            scorenum=scorenum+1;
            scoreText.text = "score:-" + scorenum.ToString();
        }
    }
}
