using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carColliderScript : MonoBehaviour
{
    public Rigidbody car;
    public BoxCollider carCollider;

    // Start is called before the first frame update
    void Start()
    {
        car = gameObject.GetComponent<Rigidbody>();
        carCollider = gameObject.GetComponent<BoxCollider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "building")
        {
            Debug.Log("You hit a building!");
        }

        else if (collision.gameObject.tag == "sidewalk")
        {
            Debug.Log("You are on the sidewalk!");
        }

        else if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("You hit an object!");
        }

        else if (collision.gameObject.tag == "tree")
        {
            Debug.Log("You hit a tree!");
        }
    }
}
