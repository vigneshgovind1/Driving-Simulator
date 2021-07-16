using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficWaypoint : MonoBehaviour
{

    public Transform[] waypoints;
    public float speed;
    public float rotateSpeed = 3.5f;

    private int waypointIndex;
    private Quaternion rotation;
    private float dist;

    private bool isStop;

    public float raycastDistance;

    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);

        if (dist < 2f)
        {
            IncreaseWaypointIndex();
        }

        Patrol();
        //transform.LookAt(waypoints[waypointIndex].position);
        
    }

    void Update(){

        //to make vehicle stop on red light trigger
        if(isStop){

            speed=0f;

        } else {

            speed=8f;
        }
    }


    private void Patrol()
    {
        // places a raycast forward which detects other vehicles
        var ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            if (hit.transform.gameObject.tag == "traffic" || transform.gameObject.tag == "Player") 
            {
                Debug.Log("You are in range of another car");
                speed = 0f;
            }

            else
            {
                speed = 8f;
            }
        }



        //to make the vehicle move towards the looking direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //to rotate the vehicle towards the waypoint
        rotation = Quaternion.LookRotation(waypoints[waypointIndex].position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotateSpeed);
    }


    private void IncreaseWaypointIndex()
    {
        waypointIndex++;

        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

     void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "stops"){
            isStop = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "stops"){
            isStop = false;
        }
    }




    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward * raycastDistance);
    }

}
