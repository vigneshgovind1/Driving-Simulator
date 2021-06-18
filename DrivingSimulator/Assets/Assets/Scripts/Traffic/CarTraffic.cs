using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTraffic : MonoBehaviour
{

    public Transform[] waypoints;
    public int speed;

    private int waypointIndex;
    private float dist;

    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);

    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (dist < 1f)
        {
            IncreaseWaypointIndex();
        }

        Patrol();
        transform.LookAt(waypoints[waypointIndex].position);
    }


    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreaseWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }

  
    }
}
