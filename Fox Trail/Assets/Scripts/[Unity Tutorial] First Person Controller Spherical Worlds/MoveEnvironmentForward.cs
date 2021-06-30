using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnvironmentForward : MonoBehaviour
{

    public float forwardSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * forwardSpeed);
        // //automatic forward movement
		// //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
        //     rb.velocity = transform.forward * forwardSpeed;
    }
}
