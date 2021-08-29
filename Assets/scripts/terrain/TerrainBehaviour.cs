using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBehaviour : MonoBehaviour
{
    public Camera camera;
    public PlayerMovement playerMovement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            Debug.DrawRay(ray.origin, ray.direction, Color.blue);
            
            if (Physics.Raycast(ray.origin, ray.direction, out hit));
            {
                playerMovement.move(hit.point);
            }
        }        
    }
}
