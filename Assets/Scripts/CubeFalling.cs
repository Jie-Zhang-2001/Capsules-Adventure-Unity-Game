using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFalling : MonoBehaviour
{
    private float randomSpeed;
    private float randomRange;
    private float mark;
    private Vector3 intialPosition;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        intialPosition = transform.position;
        randomSpeed = Random.Range(0.1f, 0.1f);
        randomRange = Random.Range(5f, 6f);
        mark = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z + randomSpeed));
        mark += randomSpeed;

        if (Mathf.Abs(mark) > randomRange)
        {
            mark = 0f;
            randomSpeed *= -1;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody x = other.gameObject.GetComponent<Rigidbody>();
        
    }
    private void OnTriggerExit(Collider other)
    {
        //other.transform.parent = null;
    }
    private void OnTriggerEnter(Collider other)
    {
        rb.useGravity = true;
        
    }
}   
