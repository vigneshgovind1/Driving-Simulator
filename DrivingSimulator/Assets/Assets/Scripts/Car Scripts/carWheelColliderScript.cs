using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carWheelColliderScript : MonoBehaviour
{

    //public Rigidbody wheel;
    public BoxCollider wheelCollider;
    public Text message;

    private float timeToAppear = 2.5f;
    private float timeToDisappear;

    // Start is called before the first frame update
    void Start()
    {
        //wheel = gameObject.GetComponent<Rigidbody>();
        wheelCollider = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(message.enabled && (Time.time >= timeToDisappear))
        {
            message.enabled = false;
        }*/
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sidewalk")
        {
            message.enabled = true;
            timeToDisappear = Time.time + timeToAppear;

            message.text = "You are on the sidewalk!";
            Debug.Log("You are on the sidewalk!");
        }

        if (other.gameObject.tag == "offroad")
        {
            message.enabled = true;
            timeToDisappear = Time.time + timeToAppear;

            message.text = "You are off the road!";
            Debug.Log("You are off the road!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "sidewalk")
        {
            message.enabled = false;
        }

        if (other.gameObject.tag == "offroad")
        {
            message.enabled = false;
        }
    }
}
