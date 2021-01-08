using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popStick : MonoBehaviour
{
    private bool entered;
    public Rigidbody rb;
    private float time;
    private bool outside;
    // Start is called before the first frame update
    void Start()
    {
        entered = false;
        outside = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (entered)
        {
            time = Time.time;
            outside = true;
            rb.MovePosition(new Vector3(rb.transform.position.x - 10f, rb.transform.position.y, rb.transform.position.z));
            entered = false;
        }
        if(outside && time + 1 < Time.time)
        {
            outside = false;
            rb.MovePosition(new Vector3(rb.transform.position.x + 10f, rb.transform.position.y, rb.transform.position.z));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        entered = true;
    }

}
