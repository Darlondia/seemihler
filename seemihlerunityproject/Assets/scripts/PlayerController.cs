using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float right;
    public float left;
    Vector2 vec;
    public Animator animator;

    void Start()
    {
        
    }


    void Update()
    {
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
            rb.velocity = new Vector2(right*Time.deltaTime, 0);
        }

        //----------SOLA HAREKET------------
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-left * Time.deltaTime, 0);
        }

    }
}
