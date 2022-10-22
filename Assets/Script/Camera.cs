using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform snake;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = snake.position + offset;
    }
}
