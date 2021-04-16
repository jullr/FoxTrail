using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    //liikkuu eteenpäin automaattisesti, sivuille 2s kamera animaation jälkeen. gravity alas päin, ei sphere muodossa. 
    //käyttää character controlleria, ei rigidbody


    // private CharacterController controller; 
    // private Vector3 moveVector;

    // private float speed = 2.0f;
    // private float verticalVelocity = 0.0f;
    // private float gravity = 12.0f;

    // private float animationDuration = 2.0f; 

    // // //sphere gravity
    // // public Transform planet; 
    // // float sphereGravity = -9.81f;

    // // Start is called before the first frame update
    // void Start(){
    //     controller = GetComponent<CharacterController>();
    // }

    // // Update is called once per frame
    // void Update(){

    //     //aloittaa liikkumisen vasta alku animaation jälkeen
    //     if(Time.time < animationDuration){
    //         controller.Move(Vector3.forward * speed * Time.deltaTime);
    //         return;
    //     }

    //     moveVector = Vector3.zero;

    //     //onko grounded
    //     if(controller.isGrounded){
    //         verticalVelocity = -0.5f;
    //     }else{
    //         verticalVelocity -= gravity * Time.deltaTime;
    //     }

    //     //X Left and Right
    //     moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

    //     //Y Up and Down
    //     moveVector.y = verticalVelocity;

    //     //Z Forward (and Backward)
    //     moveVector.z = speed;

    //     controller.Move(moveVector * Time.deltaTime);

    //     // //sphere gravity
    //     // GetComponent<Rigidbody>().AddForce((transform.position - planet.position).normalized * gravity);
    //     // transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.FromToRotation(transform.up,(transform.position - planet.position).normalized) * transform.rotation, speed * Time.deltaTime);

    // }



    //---------------------------------------------------------------------------

    // ORIGINAL . Make A 3D Platformer in Unity #3: Better Movement tutoriaali

    public float moveSpeed;
    public float jumpForce;
    public CharacterController controller;

    private Vector3 moveDirection; 

    //jotta putoaminen ei olisi niin hidasta
    public float gravityScale = 1f;

    void Start() {
        controller = GetComponent<CharacterController>();
    }

    void Update() {
        
        //vasen oikea eteen taakse liikkuminen, movement
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);
    
        //jump movement
        // if(Input.GetButtonDown("Jump")){
        //     moveDirection.y = jumpForce;
        // }

        if(controller.isGrounded){
            if (Input.GetButtonDown("Jump")){
                moveDirection.y = jumpForce;
            }
        }

        //gravity is down (y axis). Using unity's base gravity settings -9.xx..
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);

        //movement komennot kytketään player controlleriin
        controller.Move(moveDirection * Time.deltaTime);  
    
    }
   







}
