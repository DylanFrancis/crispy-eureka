using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float cameraOffset_x = 0;
    public float cameraOffset_y = 20;
    public float cameraOffset_z = -30;

    private Vector3 cameraOffset; 
    private Vector3 userToMove;

    public CameraMovement cameraMovement;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = new Vector3(cameraOffset_x, cameraOffset_y, cameraOffset_z);

        cameraMovement.setPosition(transform.position + cameraOffset);
    }

    // Update is called once per frame
    void Update()
    {
        if (userToMove != null)
        {
            float step = speed * Time.deltaTime;
            
            transform.position = Vector3.MoveTowards(transform.position, userToMove, step);

            Vector3 cameraPos = transform.position + cameraOffset; 

            onMove(cameraPos, step);
        }
    }

    public void move(Vector3 positionToMove)
    {
        userToMove = positionToMove;        
    }

    private void onMove(Vector3 toMove, float step)
    {
        cameraMovement.move(toMove, step);
    }
}
