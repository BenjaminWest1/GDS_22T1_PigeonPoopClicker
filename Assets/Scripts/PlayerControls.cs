using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject poop;
    public Vector3 spawnPos;
    [SerializeField]
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Mouse Pos relative to Camera and World Pos
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }

        // Mouse Pos relative to Camera and World Pos
        //Vector3 mousePos = Input.mousePosition;   
        //mousePos.z=Camera.main.nearClipPlane;
        //Vector3 Worldpos=Camera.main.ScreenToWorldPoint(mousePos);
        
        //Player Input "Left Click" to poop
        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(poop, raycastHit.point, Quaternion.identity);
            Instantiate(poop, raycastHit.point, Quaternion.identity);
        }
    }
}
