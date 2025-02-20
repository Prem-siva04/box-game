using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingEnemy : MonoBehaviour
{
   public float speed;
   Vector3 targetPos;
  
   public GameObject ways;
   public Transform[] movepoints;
   int pointIndex;
   int pointCont;
   [Range(0, 5)]
   public int waitTime;
   int speedMultiplier;
   int direction = 1;

   public void Awake()
   {
    movepoints = new Transform[ways.transform.childCount];
    for (int i = 0; i < ways.gameObject.transform.childCount; i++)
    {
        movepoints[i] = ways.transform.GetChild(i).gameObject.transform;
    }
   }
   public void Start()
   {
    pointIndex = 1;
    pointCont = movepoints.Length;
    targetPos = movepoints[pointIndex].transform.position;
     StartCoroutine(wait());
   }

    private void Update()
    {
        var step = speedMultiplier *  speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);

        if (transform.position == targetPos)
        {
            nextPoint();
        }
    }

    void nextPoint()
    {
        if (pointIndex == pointCont - 1)
        {
            direction = -1;
        }
        else if (pointIndex == 0)
        {
            direction = 1;
        }
        pointIndex += direction;
        targetPos = movepoints[pointIndex].transform.position;
    }

    IEnumerator wait()
    {   
        speedMultiplier = 0;
        yield return new WaitForSeconds(waitTime); // Updated to use waitTime
        speedMultiplier = 1;
    }
}