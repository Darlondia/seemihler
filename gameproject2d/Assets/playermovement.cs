using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    Vector2 movement;
    public Rigidbody2D rb;
    public float right = 250f;
    public float left = 250f;
    public float jump = 15f;
    public float down = 8f;
    public bool isGrounded = false;
    public bool forceCutOnEdges = true;



    private void Start()
    {
       forceCutOnEdges = true;
    }

    private void Update()
    {

       
        
    }


    void FixedUpdate()
    {

        if (Input.GetKey("a")&&forceCutOnEdges)
        {
            rb.velocity = new Vector2(-left * Time.deltaTime, rb.velocity.y);
            if (Input.GetKey("s"))
            {
                rb.velocity = new Vector2(-left * Time.deltaTime, -down);
            }

        }
        if (Input.GetKey("d")&& forceCutOnEdges)
        {
            rb.velocity = new Vector2(right * Time.deltaTime, rb.velocity.y);
            if (Input.GetKey("s"))
            {
                rb.velocity = new Vector2(right * Time.deltaTime, -down);
            }
        }
        if (Input.GetKeyDown("w")&& isGrounded)
        {
            rb.velocity = Vector2.up * jump;
        }
       

    }
}
