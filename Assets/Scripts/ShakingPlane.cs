using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakingPlane : MonoBehaviour
{
    // Start is called before the first frame update
    public float randomSpeed;
    public Rigidbody planeRB;
    private Quaternion deltaRotation;
    private Vector3 movement;
    void Start()
    {
        randomSpeed = Random.Range(30f, 200f);
        movement = new Vector3(planeRB.rotation.x, planeRB.rotation.y, 0);
        // StartCoroutine(rotatePlane());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 movement = new Vector3(planeRB.rotation.x, planeRB.rotation.y + Random.Range(-150f, 150f), planeRB.rotation.x + Random.Range(-150f, 150f));
        //Quaternion deltaRotation = Quaternion.Euler(movement * Time.deltaTime);
        //planeRB.MoveRotation(deltaRotation);

        movement.y += randomSpeed;
        deltaRotation = Quaternion.Euler(movement * Time.deltaTime);
        planeRB.MoveRotation(deltaRotation);
    }

    IEnumerator rotatePlane()
    {
        while (true)
        {
            Vector3 movement = new Vector3(0, planeRB.rotation.y + Random.Range(-3000f, 3000f), 0);
            deltaRotation = Quaternion.Euler(movement * Time.deltaTime);
            planeRB.MoveRotation(deltaRotation);
            yield return new WaitForSeconds(1);
        }
    }
}
