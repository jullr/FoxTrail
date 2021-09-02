using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    public AudioClip collectableAudio;
    AudioSource audioData;
    

 void Start()
 {
     audioData = GetComponent<AudioSource>();

}

    void OnTriggerEnter (Collider collisionInfo){
        if (collisionInfo.tag == "Flame"){
            //play collecting sound
            audioData.clip = collectableAudio;
            audioData.Play();
            Debug.Log("collected");

            //add value to score text
            FlameCollision.scoreValue += 10;
            
            Destroy(collisionInfo.gameObject);
        }
    }
}
