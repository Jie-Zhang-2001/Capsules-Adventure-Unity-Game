using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HikingPlane : MonoBehaviour
{
    // Start is called before the first frame update
    private float randomSpeed;
    private Rigidbody rb;
    private float mark;
    private float randomRange;
    void Start()
    {
        randomSpeed = Random.Range(0.2f, 0.4f);
        randomRange = Random.Range(20f, 25f);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }
}
