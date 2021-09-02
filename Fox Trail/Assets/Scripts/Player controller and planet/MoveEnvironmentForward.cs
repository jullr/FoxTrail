using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnvironmentForward : MonoBehaviour
{
    public float forwardSpeed = 2f; //automatic forward movement

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //automatic forward movement
        transform.Translate(-Vector3.forward * Time.deltaTime * forwardSpeed);
        
    }
}
