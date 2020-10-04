using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rigbdy;
    public float forwardForce = 2000f;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void FixedUpdate(){
        rigbdy.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigbdy.AddForce(50*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigbdy.AddForce(-50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rigbdy.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
