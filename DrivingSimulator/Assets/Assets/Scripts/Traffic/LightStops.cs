using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStops : MonoBehaviour
{
    public GameObject redlights;
    public GameObject yellowlights;
    public GameObject greenlights;

    // Update is called once per frame
    void Update()
    {
        if(yellowlights.GetComponent<Light>().enabled == true){
            this.gameObject.GetComponent<BoxCollider>().isTrigger = false;
        }
        if(greenlights.GetComponent<Light>().enabled == true){
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
        if(redlights.GetComponent<Light>().enabled == true){
            this.gameObject.GetComponent<BoxCollider>().enabled = true;
            this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }
    }
}
