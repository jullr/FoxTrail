using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravityDown : MonoBehaviour
{
    public Vector3 gravityDirection; // new Vector2(0, -9.81f) could be the default
    private Rigidbody _rb;
    void Awake() {
        _rb = GetComponent<Rigidbody>(); // cache reference since GetComponent is expensive
    }

    void FixedUpdate(){  // use FixedUpdate for physics stuff
        _rb.AddForce(gravityDirection);
    }
}
