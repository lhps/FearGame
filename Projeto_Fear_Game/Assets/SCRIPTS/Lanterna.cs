using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if(GetComponent<Light>().enabled == true)
            {
                GetComponent<Light>().enabled = false;
            }
            else if(GetComponent<Light>().enabled == false)
            {
                GetComponent<Light>().enabled = true;
            }
                
        }
    }

   

}