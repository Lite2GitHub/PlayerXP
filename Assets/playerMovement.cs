using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;
    //controller setup

    public float speed = 12f;
    //speed editor
    public float gravity = -9.81f;
    //gravity value
    public float jumpHeight = 3f;


    public Transform groundCheck;
    //How to know if grounded so velocityY can reset
    public float groundDist = .4f;
    //radius of the checking sphere
    public LayerMask groundMask;
    //Checking for the 'ground' layer

    Vector3 velocity;
    //store current velocity
    bool isGrounded;
    //simple true/false

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);
        //Grounded is based on collision of sphere, center of sphere, radius as groundDistance, and Layer check

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        //if grounded check passes and velocity is negative (aka falling), apply slight pulling force downwards to properly ground

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //grabbing moving directions from Unity 

        Vector3 move = transform.right * x + transform.forward * z;
        //moving relative to facing direction instead of cardinal directions

        controller.Move(move * speed * Time.deltaTime);
        //Movement, also framerate independent

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        //IF Jump button is pressed and the Character is grounded, then upwards velocity bop (wierd equation featuring max jump height)
        //"Jump" is auto binded to Space

        velocity.y += gravity * Time.deltaTime;
        //applying downwards velocity over time under the gravity coefficient

        controller.Move(velocity * Time.deltaTime);
        
    }

}
