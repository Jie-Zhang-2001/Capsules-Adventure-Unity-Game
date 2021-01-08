using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingFan : MonoBehaviour
{
    public Vector3 direction;
    private float randomSpeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = 150f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(direction.normalized * randomSpeed * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
