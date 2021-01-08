using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingCube : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private float range;
    public Vector3 initialPosition;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        if (initialPosition==Vector3.zero) {
            initialPosition = transform.position;
        }
       
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (rb.transform.position.y - initialPosition.y > range) {
            if (speed < 0) {

            }
            else {
                speed *= -1;
            }

        }
        else if (initialPosition.y-rb.transform.position.y > range) {
            if (speed>0) {
            }
            else {
                speed *= -1;
            }
        }

        


        rb.MovePosition(rb.position + new Vector3(0,speed,0));
    }
}
