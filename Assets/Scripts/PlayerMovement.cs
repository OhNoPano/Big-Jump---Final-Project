using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 10f;
    public float bigJump = 10f;
    public bool isGrounded = false;

    private bool Left = false;
    private bool Right = false;
    private bool buttonJump = false;

    // Update is called once per frame
    void Update () {
        Jump();
        Vector3 horizontalMove = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += horizontalMove * Time.deltaTime * moveSpeed;
    }

    void Jump () {
        if (Input.GetButtonDown("Jump") && isGrounded == true){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, bigJump), ForceMode2D.Impulse);

        }
    }
}
