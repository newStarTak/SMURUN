using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform tr;

    public float jumpForce;

    public bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        // if fall, Respawn
        if(transform.position.y < -10)
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;

            rb.velocity = new Vector2(0f, 0f);
            rb.AddForce(transform.up * jumpForce);
            //Debug.Log(Time.time);
        }
    }
    
    private void OnTriggerStay2D (Collider2D coll)
    {
        if (coll.tag == "JUMPCIRCLE" || coll.tag == "SLOPE")
        {
            isGrounded = true;     // Can Jump
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "JUMPCIRCLE" || coll.tag == "SLOPE")
        {
            isGrounded = false;     // Can't Jump
        }
    }
}
