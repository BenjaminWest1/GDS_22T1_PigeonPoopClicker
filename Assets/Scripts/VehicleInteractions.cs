using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleInteractions : MonoBehaviour
{
    public GameObject target;
    public Material carHit;
    public bool isHit = false;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Poop") && isHit == false)
        {
            target = other.gameObject;
            //Change Colour
            this.GetComponent<MeshRenderer>().material = carHit;
            //Add Audioclip noise

            //Add to score
            FindObjectOfType<ScoreScript>().UpdateScore(100);
            isHit = true;

            Debug.Log("Hit Confirmed");
        }
        
    }
}
