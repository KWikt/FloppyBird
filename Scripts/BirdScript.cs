using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour

{
    public Rigidbody2D rigidBody;
    public float flightHighMultiply;
    public GameObject logicMenager;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public SoundEfectPlayer sound;
   
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        sound = GameObject.FindGameObjectWithTag("Logic").GetComponent<SoundEfectPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        flight();
        

    }


    public void flight()
    {

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            
            sound.FlyightSound();
            rigidBody.velocity = Vector2.up * flightHighMultiply;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}







