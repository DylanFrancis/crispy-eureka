using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPosition(Vector3 toSet)
    {
        transform.position = toSet;

        Debug.Log(toSet);
    }

    public void move(Vector3 toMove, float step)
    {
        transform.position = Vector3.MoveTowards(transform.position, toMove, step);
    }
}
