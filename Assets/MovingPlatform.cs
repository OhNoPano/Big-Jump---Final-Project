using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    
    public float speed = 5;
    public float distance = 50;
    public float travelTime = 10;
    
    Vector3 pointA = new Vector3(0, 0, 0);
    Vector3 pointB = new Vector3(5, 0, 0);
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time / 2, 1));
    }

}
