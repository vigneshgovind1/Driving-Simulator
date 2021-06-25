using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossingNPC_script : MonoBehaviour
{

    public Transform[] waypoints;
    public float speed = 3f;

    private int waypointIndex;
    private float dist;
    public float coroutineTime = 7f;

    public bool isCoroutineStarted = false;


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
            if (!isCoroutineStarted)
            {
                StartCoroutine(CrossRoad());
                //IncreaseWaypointIndex();
            }

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

    IEnumerator CrossRoad()
    {
        isCoroutineStarted = true;
        speed = 0f;
        yield return new WaitForSeconds(coroutineTime);
        IncreaseWaypointIndex();
        speed = 3f;
        isCoroutineStarted = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("You hit a pedestrian");
        }
    }
}
