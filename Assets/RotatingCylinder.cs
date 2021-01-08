using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCylinder : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;
    private float randomSpeed;
    private Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = 1f;
        rb = GetComponent<Rigidbody>();
        movement = new Vector3(0,randomSpeed,  0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(movement * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
        if (playerRB != null) {
            rotateRigidBodyAroundPointBy(playerRB,rb.position,Vector3.up,randomSpeed);
        }
    }

    public void rotateRigidBodyAroundPointBy(Rigidbody rb, Vector3 origin, Vector3 axis, float angle)
    {
        Quaternion q = Quaternion.AngleAxis(angle, axis);
        rb.MovePosition(q * (rb.transform.position - origin) + origin);
        rb.MoveRotation(rb.transform.rotation * q);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerRB = other.gameObject.GetComponent<Rigidbody>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerRB = null;
        }

    }

    
}
