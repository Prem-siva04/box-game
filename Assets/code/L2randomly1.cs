using UnityEngine;

public class L2randomly1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public L2randomly1 rand;
    private float Ntimer1 = 0f;
    private float Ninterval1 = 3f; // 4 seconds

    void Start()
    {
        NewEnemyPosition1(); // Call ChangePosition to set a random starting position
    }

    void Update()
    {
        Ntimer1 += Time.deltaTime; // Increment timer by the time passed since last frame
        if (Ntimer1 >= Ninterval1)
        {
            NewEnemyPosition1();
            Ntimer1 = 0f; // Reset timer
        }
    }

    public void NewEnemyPosition1()
    {
        Vector2 newposition = new Vector2(Random.Range(-7f, -1f), Random.Range(15f, 17f));
        rand.transform.position = newposition;
    }
}
