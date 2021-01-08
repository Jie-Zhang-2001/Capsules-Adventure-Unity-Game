using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSpeed;
    public Transform player;
    public float speed;
    public CharacterController controller;
    //public Rigidbody rb;
    public float jumpHeight = 3f;
    private Vector3 velocity;
    public float gravity = -9.81f;
    private bool isGrounded;
    public int counter;
    private float gravityTemp;
    float KeyDownTime = float.MinValue;
    void Start()
    {
        gravityTemp = gravity;
    }

    // Update is called once per frame
    void Update()
    {
           
            gravity = gravityTemp;
            float X = Input.GetAxis("Mouse X") * mouseSpeed;
            player.Rotate(0, X, 0);
       
            

            isGrounded = controller.isGrounded;
            if (Input.GetButtonDown("Jump") && counter < 2)
            {
                counter++;
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            if (isGrounded)
            {
                counter = 0;
            }

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            if (Input.GetMouseButtonDown(0))
            {
                KeyDownTime = Time.time;
            }

            if (Input.GetMouseButton(0) && Time.time < KeyDownTime + 1)
            {
                gravityTemp = gravity;
                gravity = 1;
            }


            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
           
            Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime );
        

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        
        
    }
}
