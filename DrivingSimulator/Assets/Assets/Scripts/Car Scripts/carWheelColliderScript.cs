using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carWheelColliderScript : MonoBehaviour
{

    //public Rigidbody wheel;
    public BoxCollider wheelCollider;

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
            Debug.Log("You are on the sidewalk!");
        }
    }
}
