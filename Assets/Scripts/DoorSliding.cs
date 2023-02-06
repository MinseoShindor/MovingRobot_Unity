using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;


public class DoorSliding : MonoBehaviour
{
    
    bool flag; // Bool for adjusting Door Open
    public GameObject door; //Door For Entering Building 


    void Start()
    {
        flag = false;   
        // door.transform.position.y = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        flag = true;
    }

    private void OnTriggerExit(Collider other) 
    {
        flag = false;
    }


    void Update()
    {
        if(flag == true) //open
        {
            if(door.transform.position.y <= 3.5)
            {
                door.transform.Translate(0,0.05f, 0);
            }
        }

        if(flag == false) //close
        {
            if(door.transform.position.y > 5) {

                door.transform.Translate(0, -0.05f, 0);

            }

        }
    }
}
