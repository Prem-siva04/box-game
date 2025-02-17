using UnityEngine;

public class Randomly : MonoBehaviour
{
    public Randomly enemy;
    private float timer = 0f;
    private float interval = 2.5f; // 2.5 seconds

    void Start()
    {
        ChangePosition(); // Call ChangePosition to set a random starting position
    }

    void Update()
    {
        timer += Time.deltaTime; // Increment timer by the time passed since last frame
        if (timer >= interval)
        {
            ChangePosition();
            timer = 0f; // Reset timer
        }
    }

   public void ChangePosition()
    {
        Vector2 newposition = new Vector2(Random.Range(-9.6f, 9.7f), Random.Range(15f, 17f));
        enemy.transform.position = newposition;
    }
}



