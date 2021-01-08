using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweeper : MonoBehaviour
{
    // Start is called before the first frame update
    private float randomSpeed;
    private float range;
    private Vector3 intialPosition;
    private float mark;
    void Start()
    {
        intialPosition = transform.position;
        randomSpeed = Random.Range(0.7f, 1.5f);
        range = 30f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(new Vector3(transform.position.x, transform.position.y, transform.position.z - randomSpeed));
        mark += randomSpeed;
        if(Mathf.Abs(mark) > range)
        {
            randomSpeed *= -1;
        }
    }

}
