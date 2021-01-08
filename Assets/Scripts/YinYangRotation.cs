using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YinYangRotation : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;
    private float randomSpeed;
    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(0.1f, 1f);
        rb = GetComponent<Rigidbody>();
        movement = new Vector3(0, randomSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.RotateAroundLocal(Vector3.up,randomSpeed*Time.deltaTime);
        Quaternion deltaRotation = Quaternion.Euler(movement * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
