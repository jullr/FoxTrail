using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animcon : MonoBehaviour
{
    void Start()
    {
        GetComponent<Animator>().Play("Run");
        
    }

    void Update()
    {
        
    }
}
