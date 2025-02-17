using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public PlayerMomement movement;
    public int count = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {


        if (collisionInfo.collider.tag == "enemy")
        {

            movement.speed = 0f;
            movement.jumpForce = 0f;
            count++;
            Gamemanger gameManager = FindFirstObjectByType<Gamemanger>();
            if (gameManager != null)
            {
                gameManager.GameOver();
                SceneManager.LoadScene(11);

            }
            else
            {
                Debug.LogError("Gamemanger instance not found!");
            }
        }
    }
}
