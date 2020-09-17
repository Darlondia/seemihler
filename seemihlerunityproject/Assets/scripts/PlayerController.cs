using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float right;
    public float left;
    public float jump;
    Vector2 vec;
    public Animator animator;
    public AudioSource asc;

    void Start()
    {
        
    }


    void Update()
    {

        


        //------ZIPLAMA--------

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }



        //---------SAGA DOGRU HAREKET ANIMASYONU----------------------
        if (Input.GetKeyDown("d"))
        {
            animator.SetFloat("SpeedSag", right);
        }
        if (Input.GetKeyUp("d"))
        {
            animator.SetFloat("SpeedSag", 0);
        }

        //-------------SOLA DOĞRU HAREKET ANIMASYONU------------------
        if (Input.GetKeyDown("a"))
        {
            animator.SetFloat("SpeedSol", left);
        }
        if (Input.GetKeyUp("a"))
        {
            animator.SetFloat("SpeedSol", 0);
        }

    }

    void FixedUpdate()
    {

        //----------SAGA HAREKET------------
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(right*Time.deltaTime, rb.velocity.y);
        }

        //----------SOLA HAREKET------------
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-left * Time.deltaTime, rb.velocity.y);
        }

    }
}
