using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticMouseLook : MonoBehaviour
{

    public float lookSens = 100f;
    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * lookSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * lookSens * Time.deltaTime;
        // xRotate is up/down; yRotate is sideways

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        

    }
}
