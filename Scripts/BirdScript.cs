using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rig;
    public float fly = 10;
    public bool isAlive = true;
    public Gamemenager Logic;
    public float DeadZone = 16;
    public AudioClip Fly1,Hit,End;
    public AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive == true || Input.GetKeyDown(KeyCode.Mouse0) && isAlive == true) 
        {
            src.clip = Fly1;
            rig.velocity = Vector2.up * fly;
            src.Play();
        }

        if(transform.position.y > DeadZone || transform.position.y < -DeadZone)
        {
            if (isAlive == true){
                src.clip = End;
                isAlive = false;
                src.Play();
                Logic.gameOver();
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(isAlive == true)
        {
            src.clip = Hit;
            src.Play();
            isAlive = false;
            Logic.gameOver();
            
        }
        
    }
   
}
