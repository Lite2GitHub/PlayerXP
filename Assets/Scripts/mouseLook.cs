using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{

    public float mouseSens = 100f;
    //100 sens as default

    public Transform playerBody;
    //attach the playerbody to the script on Camera allowing for model to rotate on X

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor begon when press Play
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        //setting up mouse X & Y, pulling the axis from Unity, * Sens * Time (non framerate dependent)

        xRotation -= mouseY;
        //'-=' cause '+=' is flipped direction

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //restricting looking at the Y axis too far up/down

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Funny rotation Unity, step required cause Clamp

        playerBody.Rotate(Vector3.up * mouseX);
        //rotate model sideways following mouse, therby turning Cam attached
    }
}
