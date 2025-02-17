using UnityEngine;

public class Boxcollision : MonoBehaviour


{
    public GameObject box;
    public int boxCount = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
    void OnCollisionEnter2D(Collision2D boxInfo)
    {
        if (boxInfo.collider.tag == "enemy"){
            boxCount++;
        }
    }
}
