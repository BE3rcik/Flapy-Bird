using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGene : MonoBehaviour
{
    public GameObject Pipe;
    public float Spawn = 3;
    private float currentTime = 0;
    public float heightOffset = 16;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < Spawn)
        {
            
            currentTime = currentTime  + Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            currentTime = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
        
    }
}
