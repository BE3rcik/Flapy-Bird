using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePointMan : MonoBehaviour
{
    public Gamemenager Logic;
    public AudioClip Earn;
    public AudioSource src;
    public BirdScript Bird;

    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Manager").GetComponent<Gamemenager>();
        Bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8 && Bird.isAlive)
        {
            src.clip = Earn;
            Logic.addScore(1);
            src.Play();
        }
        
    }
}
