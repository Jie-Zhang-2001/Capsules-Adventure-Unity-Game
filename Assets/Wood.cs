using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    private bool destroy;
    private float createTime;
    // Start is called before the first frame update
    void Start()
    {
        destroy = false;
        createTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<-100) {
            destroy = true;
        }

        if (Time.time > createTime + 60) {
            destroy = true;
        }
    }

    private void FixedUpdate()
    {
        if (destroy) {
            Destroy(gameObject);
        }
    }
}
