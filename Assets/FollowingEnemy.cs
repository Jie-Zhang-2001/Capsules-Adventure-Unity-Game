using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingEnemy : MonoBehaviour
{
    private Rigidbody target;
    private Rigidbody rb;
    private float randomSpeed;
    private bool bomb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        randomSpeed = Random.Range(10f,50f);
        bomb = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) {
            if ( (target.position-rb.position).magnitude <= 5f ) {
                bomb = true;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Player") {
            target = other.gameObject.GetComponent<Rigidbody>();
            
        }
       
    }

    private void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 dir = target.position - rb.position;

            rb.MovePosition(rb.position + dir.normalized * randomSpeed * Time.deltaTime);
        }

        if (bomb) {
            Vector3 forceDir = target.position - rb.position;
            target.AddForce(forceDir.normalized* 1000);
            target.velocity = new Vector3(target.velocity.x,target.velocity.y+1,target.velocity.z);
            bomb = false;
        }
    }
}
