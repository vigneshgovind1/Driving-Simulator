using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightSystem : MonoBehaviour
{
    public GameObject system;
    public List<GameObject> lights = new List<GameObject>();
    //public GameObject[] intersection;
    int numTrafficPoles;
    //int intersectionPoles;
    int controlNum = 1;

    // Start is called before the first frame update
    void Start()
    {
        numTrafficPoles = system.transform.childCount;
        // lights = new GameObject[numTrafficPoles];
        for (int i = 0; i < numTrafficPoles; i++){
            lights.Add(system.transform.GetChild(i).gameObject);
        }

        InvokeRepeating("stoping",1.0f, 15f);
        InvokeRepeating("stop",4.0f,15f);
        
        InvokeRepeating("getset",7.0f,15f);
        InvokeRepeating("go",10.0f,15f);


    }

    //---------------------------previous traffic light---------------//
    void stoping()
    {


        controlNum -=1;

        // disable green light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(0).GetComponent<Light>().enabled = false;
        }

        //enable yellow light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(1).GetComponent<Light>().enabled = true;
        }

    }

    void stop(){

        //disable yellow light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(1).GetComponent<Light>().enabled = false;
        }

        //enable red light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(2).GetComponent<Light>().enabled = true;
        }

    }

    //------------------------------------------present traffic light--------------------------------------------------//

    void getset(){

        controlNum +=1;
        // diable red light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(2).GetComponent<Light>().enabled = false;
        }

        // enable yellow light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(1).GetComponent<Light>().enabled = true;
        }

    }

    void go(){
        
        //disable yellow light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(1).GetComponent<Light>().enabled = false;
        }
        
        //enable green light
        for (int i = 0; i < numTrafficPoles; i++){
            lights[i].transform.GetChild(controlNum%lights[i].transform.childCount).transform.GetChild(0).GetComponent<Light>().enabled = true;
        }

        controlNum+=1;
    }
}
