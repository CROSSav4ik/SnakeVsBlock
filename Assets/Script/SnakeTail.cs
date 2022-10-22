using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public Transform SnakeBody;
    public float SnakeTailDistant;

    private List<Transform> snakeTail = new List<Transform>();
    private List<Vector3> positionSnake = new List<Vector3>();

    private void Awake()
    {
        positionSnake.Add(SnakeBody.position);
    }

    
    void Update()
    {
        float distance = (SnakeBody.position - positionSnake[0]).magnitude;

        if (distance > SnakeTailDistant)
        {
            Vector3 direcrion = (SnakeBody.position - positionSnake[0]).normalized;
            positionSnake.Insert(0, positionSnake[0] + direcrion * SnakeTailDistant);

            distance -= SnakeTailDistant;

        }

        for (int i = 0; i < snakeTail.Count; i++)
        {
            snakeTail[i].position = Vector3.Lerp(positionSnake[i + 1], positionSnake[i], distance / SnakeTailDistant); 
        }
    }
    public void AddBone()
    {
        Transform Bone = Instantiate(SnakeBody, positionSnake[positionSnake.Count - 1], Quaternion.identity, transform);
        snakeTail.Add(Bone);
        positionSnake.Add(Bone.position);

    }
    public void DeleteBone()
    {
        Destroy(snakeTail[0].gameObject);
        snakeTail.RemoveAt(0);
        positionSnake.RemoveAt(1);
    }


}
