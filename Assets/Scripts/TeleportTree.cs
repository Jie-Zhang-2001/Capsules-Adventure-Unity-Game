using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTree : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Player")
        {
            
            other.gameObject.transform.position = new Vector3(720, 37, 441);

        }
    }
    void Update()
    {
        
    }
}
