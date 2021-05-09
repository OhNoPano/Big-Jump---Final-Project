using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crumble : MonoBehaviour
{

    public float fallDelay = 3.0f;
    
    private Vector3 location;

    private bool collided = false;

    public Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        location = transform.position;
        collided = false;
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name == "Player" && collided == false)
        {
            collided = true;
            StartCoroutine(fallAfterDelay());
            collided = false;
        }
        
    }

    IEnumerator fallAfterDelay()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Rigidbody2D>().isKinematic = false;
        yield return new WaitForSeconds(3f);
        transform.position = location;
        GetComponent<Rigidbody2D>().isKinematic = true;
        rb.velocity = Vector3.zero;
        rb.Sleep();
        //rb.angularVelocity = Vector3.zero;
    }

    

}
