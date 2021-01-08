using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLand : MonoBehaviour
{
    public GameObject prefab;
    
    public  int width;
    public  int length;
    public GameObject endScene;
    
    // Start is called before the first frame update
    void Start()
    {
        
        for (int j=0;j<length;j++) {
            for (int i = 0; i < width; i++)
            {
                Vector3 position = new Vector3(transform.position.x + j, transform.position.y+j, transform.position.z+i);

                GameObject go =   Instantiate(prefab, position, Quaternion.identity) as GameObject;
                
                go.GetComponent<JumpingCube>().initialPosition = new Vector3(position.x, transform.position.y ,position.z);
                
                go.transform.SetParent(transform);
                if (j==length-1 && i == width-1) {
                    GameObject es = Instantiate(endScene,go.transform.position,Quaternion.identity) as GameObject;
                    es.transform.parent = go.transform;
                    
                }
            }
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
       
       
    }
}
