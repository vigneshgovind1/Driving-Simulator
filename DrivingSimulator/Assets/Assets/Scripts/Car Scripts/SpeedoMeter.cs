using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedoMeter : MonoBehaviour
{
    
    public Rigidbody target;
    [Header("UI")]
    public Text SpeedText;
    public int speedLimit;

    private float speed;
    private Vector3 position;
    // Update is called once per frame
    void Update()
    {
        
        speed = target.velocity.magnitude * 2.9f;
        position = target.position;
        colorcheck((int)speed);
        //Debug.Log(speed +" "+position);
        SpeedText.text = ((int)speed) + " MPH";
    }
    void colorcheck(int speed)
    {
        if(speed>=speedLimit)
        {
            SpeedText.color =Color.red;
        }

        else if(speed == 0)
        {
            SpeedText.color = Color.white;
        }

        else if(speed<speedLimit && speed>=speedLimit-20)
        {
            SpeedText.color = Color.yellow;
        }
        else
        {
            SpeedText.color = Color.green;
        }
    }
}
