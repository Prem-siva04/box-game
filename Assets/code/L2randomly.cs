using UnityEngine;

public class L2randomly : MonoBehaviour
{
    public L2randomly ran;
    private float Ntimer = 0f;
    private float Ninterval = 1.7f; 

    void Start()
    {
        NewEnemyPosition(); // Call ChangePosition to set a random starting position
    }

    void Update()
    {
        Ntimer += Time.deltaTime; // Increment timer by the time passed since last frame
        if (Ntimer >= Ninterval)
        {
            NewEnemyPosition();
            Ntimer = 0f; // Reset timer
        }
    }

    public void NewEnemyPosition()
    {
        Vector2 newposition = new Vector2(Random.Range(7f, 2f), Random.Range(15f, 17f));
        ran.transform.position = newposition;
    }
}

