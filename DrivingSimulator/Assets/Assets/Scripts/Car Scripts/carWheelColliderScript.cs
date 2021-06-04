using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carWheelColliderScript : MonoBehaviour
{

    //public Rigidbody wheel;
    public BoxCollider wheelCollider;
    public Text message;

    // Start is called before the first frame update
    void Start()
    {
        //wheel = gameObject.GetComponent<Rigidbody>();
        wheelCollider = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sidewalk")
        {
            message.text = "You are on the sidewalk!";

            Debug.Log("You are on the sidewalk!");
        }

        if (other.gameObject.tag == "offroad")
        {
            message.text = "You are off the road!";

            Debug.Log("You are off the road!");
        }
    }
}
