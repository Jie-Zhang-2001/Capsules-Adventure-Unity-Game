using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotater : MonoBehaviour
{
    private float randomSpeed;
    private Vector3 movement;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(100f, 500f);
        rb = GetComponent<Rigidbody>();
        movement = new Vector3(0, randomSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(movement * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
