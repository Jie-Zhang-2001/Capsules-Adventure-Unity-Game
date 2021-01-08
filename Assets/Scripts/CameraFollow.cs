using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float mouseSpeed = 100f;
    public Transform playerBody;
    float xRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float scrollWheelChange = Input.mouseScrollDelta.y * 1;
        transform.position += transform.forward * scrollWheelChange;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -50f, 75f);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }
}
