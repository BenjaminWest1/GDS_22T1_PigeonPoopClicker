using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleInteractions : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Poop"))
        {
            target = other.gameObject;
            //Add Audioclip noise

            //Add to score

            Debug.Log("Hit Confirmed");
        }
        
    }
}
