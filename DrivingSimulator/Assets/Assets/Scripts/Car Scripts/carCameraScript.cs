using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCameraScript : MonoBehaviour
{

    float rotationOnX;
    float rotationOnY;
    public float mouseSensitivity = 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //taking mouse input
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;

        /*
        //rotate cam up and down
        rotationOnX -= mouseY;
        rotationOnX = Mathf.Clamp(rotationOnX, -30f, 30f);
        transform.localEulerAngles = new Vector3(rotationOnX, 0f, 0f);
        */

        //rotate cam left and right
        rotationOnY += mouseX;
        rotationOnY = Mathf.Clamp(rotationOnY, -80f, 80f);
        transform.localEulerAngles = new Vector3(0f, rotationOnY, 0f);
    }
}
