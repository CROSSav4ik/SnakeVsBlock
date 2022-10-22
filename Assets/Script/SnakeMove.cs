using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMove : MonoBehaviour
{
    public Vector3 Movement;
    public Vector3 MovementLeft;
    public Vector3 MovementRight;
    

    
    void FixedUpdate()
    {
        
        transform.Translate(Movement * Time.deltaTime);
        if (Input.GetKey("d"))
        {
          transform.Translate(MovementRight * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
           transform.Translate(MovementLeft * Time.deltaTime);
        }
        

        
        
    }
}
