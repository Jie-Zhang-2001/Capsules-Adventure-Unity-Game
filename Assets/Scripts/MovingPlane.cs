using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlane : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb1;
    public Rigidbody rb;
    private float randomSpeed;
    private float randomRange;
    private Vector3 intialPosition;
    private float mark;
    void Start()
    {
        intialPosition = transform.position;
        randomSpeed = Random.Range(0.1f,0.1f);
        randomRange = Random.Range(5f,10f);
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
        
        if (Mathf.Abs(mark)> randomRange)
        {
            mark = 0f;
            randomSpeed *= -1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        //other.transform.parent = transform;
        if (rb != null)
        {
            rb.useGravity = true;
            rb.AddForce(0, -1000, 0);
        }
       if (rb1 != null)
        {
            rb1.useGravity = true;
            rb1.AddForce(0, -1000, 0);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody x = other.gameObject.GetComponent<Rigidbody>();
        //x.MovePosition(x.transform.position+new Vector3(0,0,randomSpeed));
    }
    private void OnTriggerExit(Collider other)
    {
       //other.transform.parent = null;
    }

   
}
