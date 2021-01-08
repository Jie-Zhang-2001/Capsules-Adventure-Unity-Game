using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDown : MonoBehaviour
{
    private Vector3 initialPosition;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
