using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public Gamemenager Logic;
    public float Dead = -34;
    public float MoveSpeed = 5;

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * MoveSpeed) * Time.deltaTime;
        if(transform.position.x < Dead)
        {
            Destroy(gameObject);
        }
    }
}
