using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleInteractions : MonoBehaviour
{
    public GameObject target;
    public Material carHit;

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
            //Change Colour
            this.GetComponent<MeshRenderer>().material = carHit;
            //Add Audioclip noise

            //Add to score
            FindObjectOfType<ScoreScript>().UpdateScore(1);

            Debug.Log("Hit Confirmed");
        }
        
    }
}
