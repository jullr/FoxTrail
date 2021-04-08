using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // public Rigidbody rb;
    // public float forwardForce = 2000f;
    // public float sidewaysForce = 500f;

    // public float jumpSpeed = 8.0f;

    private Vector3 moveDirection = Vector3.zero;

    private CharacterController controller;
    // private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float forwardSpeed = 10.0f;
    // public float jumpHeight = 1.0f;
    // public float gravityValue = -9.81f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
    //eulerit liikuttaa asteittain, esim 0, 45, 90...
        //    if(Input.GetAxis("Horizontal") > 0){
        //     transform.localRotation =  Quaternion.Euler(new Vector3(0, 0, Input.GetAxis("Horizontal")));
            
        //    }else if(Input.GetAxis("Horizontal") < 0){
        //     transform.localRotation = Quaternion.Euler(new Vector3(0, 0, Input.GetAxis("Horizontal")));
        //    }

        //movement and jump
        // moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // moveDirection = transform.TransformDirection(moveDirection);
            if (Input.GetAxis("Horizontal") > 0) {
                transform.Rotate(0, 0, -playerSpeed);
            }else if (Input.GetAxis("Horizontal") < 0) {
                transform.Rotate(0, 0, playerSpeed);
            }

        // moveDirection = new Vector3(0,0, forwardSpeed);
        // controller.Move(moveDirection * Time.deltaTime);
        transform.position += (transform.forward * forwardSpeed ) * Time.deltaTime;

        // moveDirection *= playerSpeed; 
        // if(Input.GetButton("Jump")){
        //     moveDirection.y= jumpHeight;
        // }
        
        // // moveDirection.y -= gravityValue * Time.deltaTime;
        // controller.Move(moveDirection * Time.deltaTime);


        // //key presses d and a yms. 
        // rb.AddForce(0,0,forwardForce * Time.deltaTime);

        // if (Input.GetKey("d")){
        //     rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        // }

        // if (Input.GetKey("a")){
        //     rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        // }

        // if (rb.position.y < -1f){
        //     FindObjectOfType<GameManager>().EndGame();
        // }

        // if (Input.GetKey("w")){
        //     rb.AddForce(0, jumpSpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
            
        // }
    }
}
