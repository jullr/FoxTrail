using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public FirstPersonController movement;
    public MoveEnvironmentForward forwardMovement;
    public AudioSource hitAudioSource;
    public AudioSource runAudioSource;
    public Animator playerAnimator;

    void OnCollisionEnter (Collision collisionInfo){
        
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            forwardMovement.enabled = false; //end forward movement of environment
            hitAudioSource.Play();
            playerAnimator.Play("FoxDeath");//play death animation
            runAudioSource.Stop();

            FlameCollision.scoreValue = 0;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
