using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWoodAndRock : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private float prevTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Time.time > prevTime +1f) {
            prevTime = Time.time;
            
            GameObject go =  Instantiate(prefab, transform.position, prefab.transform.rotation) as GameObject;
            go.transform.SetParent(transform);

        }
    }
}
