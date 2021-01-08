using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig1 : MonoBehaviour
{
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -50)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
