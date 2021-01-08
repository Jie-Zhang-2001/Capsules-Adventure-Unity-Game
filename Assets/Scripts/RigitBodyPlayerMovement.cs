using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigitBodyPlayerMovement : MonoBehaviour
{
    public float mouseSpeed;
    public Transform player;
    public float speed;
    private Rigidbody rb;
    public Transform groundCheck;
    public LayerMask playerMask;
    //public Transform cam;
    public Camera cam;
    private bool grounded;
    private int counter;
    public bool useGravity = true;
    float KeyDownTime = float.MinValue;
    private bool jumped;
    Vector3 Movement;
    private bool moved;
    private bool spring;
    public float springSpeed;
    private  float speedBackUp;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedBackUp = speed;
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (spring)
        {

            speed = springSpeed;
        }
        else {
            speed = speedBackUp;
        }
        


        if (moved)
        {
            rb.MovePosition(rb.position + Movement);
            moved = false;
        }

        if ( Physics.OverlapSphere(groundCheck.position, 0.03005f, playerMask).Length > 0)
        {


            grounded = true;
            counter = 0;

        }
        else
        {
            grounded = false;
        }

        if (jumped) {
            if (grounded)
            {
                rb.AddForce(0, 3000, 0);
                counter++;
                grounded = false;

            }
            else if (!grounded && counter < 2)
            {
                rb.AddForce(0, 3000, 0);
                counter++;
            }
            jumped = false;
        }

        if (useGravity) rb.AddForce(Physics.gravity * (rb.mass * rb.mass));

        if (Input.GetMouseButton(1))
        {
            float down = -9.81f * rb.mass * rb.mass * 2;
            rb.AddForce(0f, down, 0f);
        }
        if (Input.GetMouseButton(0))
        {
            //rigidbody.useGravity = false;
            rb.AddForce(Physics.gravity * -1 * (rb.mass * rb.mass));
        }
    }
    void Update()
    {
        if(rb.position.y < -100)
        {
            //transform.position = new Vector3(0, 1, 0);
            Application.LoadLevel(Application.loadedLevel);
        }
        float X = Input.GetAxis("Mouse X") * mouseSpeed;
        player.Rotate(0, X, 0);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if(Mathf.Abs(x) > 0 || Mathf.Abs(z) > 0)
        {
            moved = true;
        }
        Movement = new Vector3(x * speed, 0f, z * speed);
        Movement = Quaternion.Euler(0, cam.transform.eulerAngles.y, 0) * Movement;

        if (Input.GetButtonDown("Jump") )
        {
            jumped = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (spring)
            {
                spring = false;
            }
            else {
                spring = true;
            }
            
        }

        
        
        
    }

}
