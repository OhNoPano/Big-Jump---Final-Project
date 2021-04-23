using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 pointA = new Vector3(0, 0, 0);
    public Vector3 pointB = new Vector3(5, 0, 0);
    public float speedDivider = 2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time / speedDivider, 1));
    }

}
