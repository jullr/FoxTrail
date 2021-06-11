﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public FirstPersonController movement; 

    void OnCollisionEnter (Collision collisionInfo){
        
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false; 
            FlameCollision.scoreValue = 0;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
