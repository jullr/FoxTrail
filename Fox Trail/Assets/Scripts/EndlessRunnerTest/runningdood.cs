using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runningdood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
    }

    // Update is called once per frame
    void Update()
    {
        //moving left and right
        if (Input.GetKey("d")){
            GetComponent<Rigidbody>().velocity = new Vector3(2.5f,0,3);
        }else if (Input.GetKey("a")){
            GetComponent<Rigidbody>().velocity = new Vector3(-2.5f,0,3);
        }else{
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
        }
    }

    //Stops the movement
    // IEnumerator stopLaneCh(){
    //     yield return new WaitForSeconds (1);
    //     GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
    // }
}
