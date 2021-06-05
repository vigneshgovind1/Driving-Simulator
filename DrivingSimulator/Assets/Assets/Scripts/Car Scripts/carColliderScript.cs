using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carColliderScript : MonoBehaviour
{
    public Rigidbody car;
    public BoxCollider carCollider;
    public Text message;

    private float timeToAppear = 2.5f;
    private float timeToDisappear;


    // Start is called before the first frame update
    void Start()
    {
        car = gameObject.GetComponent<Rigidbody>();
        carCollider = gameObject.GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(message.enabled && (Time.time >= timeToDisappear))
        {
            message.enabled = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "building")
        {
            message.enabled = true;
            timeToDisappear = Time.time + timeToAppear;

            message.text = "You hit a building!";
            Debug.Log("You hit a building!");
        }

        else if (collision.gameObject.tag == "sidewalk")
        {
            message.enabled = true;
            timeToDisappear = Time.time + timeToAppear;

            message.text = "You are on the sidewalk!";
            Debug.Log("You are on the sidewalk!");
        }

        else if (collision.gameObject.tag == "obstacle")
        {
            message.enabled = true;
            timeToDisappear = Time.time + timeToAppear;

            message.text = "You hit an object!";
            Debug.Log("You hit an object!");
        }

        else if (collision.gameObject.tag == "tree")
        {
            message.enabled = true;
            timeToDisappear = Time.time + timeToAppear;

            message.text = "You hit a tree!";
            Debug.Log("You hit a tree!");
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        
    }


}
