using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crumble : MonoBehaviour
{

    public float fallDelay = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
    
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            StartCoroutine(fallAfterDelay());
        }
        
    }

    IEnumerator fallAfterDelay()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Rigidbody2D>().isKinematic = false;
    }

}
