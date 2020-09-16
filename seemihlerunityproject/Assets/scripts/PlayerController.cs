using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float right;
    public float left;
    Vector2 vec;

    void Start()
    {
        
    }

    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(right*Time.deltaTime, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-left * Time.deltaTime, 0);
        }

    }

}
