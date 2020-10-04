using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float right;
    public float left;
    public float jump;
    
    void FixedUpdate()
    {

        //----------SAGA HAREKET------------
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(right * Time.deltaTime, rb.velocity.y);
        }

        //----------SOLA HAREKET------------
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-left * Time.deltaTime, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jump;
        }
    }



}

