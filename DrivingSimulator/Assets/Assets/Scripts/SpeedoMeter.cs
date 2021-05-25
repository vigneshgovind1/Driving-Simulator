using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedoMeter : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody target;
    [Header("UI")]
    public Text SpeedText;
    public int speedLimit;

    private float speed;
    // Update is called once per frame
    void Update()
    {
        
        speed = target.velocity.magnitude * 3.0f;
        colorcheck((int)speed);
        Debug.Log((int)speed);
        SpeedText.text = ((int)speed) + " MPH";
    }
    void colorcheck(int speed)
    {
        if(speed>=speedLimit)
        {
            SpeedText.color =Color.red;
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
