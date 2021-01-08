using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFalling : MonoBehaviour
{
    
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.y < -100) {
            GetComponent<Rigidbody>().isKinematic = true; 
       }
            
    }
}
