using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    private Vector3 userToMove;

    // Start is called before the first frame update
    void Start()
    {
               
    }

    // Update is called once per frame
    void Update()
    {
        if (userToMove != null)
        {
            Debug.Log("moving");
            
            float step = speed * Time.deltaTime;
            
            transform.position = Vector3.MoveTowards(transform.position, userToMove, step);
        }
    }

    public void move(Vector3 positionToMove)
    {
        userToMove = positionToMove;        
    }
}
