using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float right = 250.0f;
    public float left = 250.0f;
    public float jump = 15.0f;

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(right * Time.deltaTime, rb.velocity.y);
        }

        //----------SOLA HAREKET------------
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-left * Time.deltaTime, rb.velocity.y);
        }
        if (Input.GetKeyDown("w"))
        {
            rb.velocity = Vector2.up * jump;
        }
    }
}
