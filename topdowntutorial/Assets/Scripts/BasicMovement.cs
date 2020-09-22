using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()

    {

     
       
        Vector3 vector;
        if (Input.GetKey("a"))
        {
            animator.SetFloat("Horizontal", -1);
            vector = new Vector3(-5.0f,0.0f,0.0f);

            transform.position = transform.position + vector * Time.deltaTime;
        }
        else if (Input.GetKey("d"))
        {
            animator.SetFloat("Horizontal", 1);
            vector = new Vector3(5.0f, 0.0f, 0.0f);

            transform.position = transform.position + vector * Time.deltaTime;
        }
        else
        {
            animator.SetFloat("Horizontal", 0);
        }
        if (Input.GetKey("w"))
        {
            vector = new Vector3(0.0f, 5.0f, 0.0f);

            transform.position = transform.position + vector * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            vector = new Vector3(0.0f, -5.0f, 0.0f);

            transform.position = transform.position + vector * Time.deltaTime;
        }



    }
}
