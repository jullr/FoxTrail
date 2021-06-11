using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    public AudioClip collectableAudio;
    AudioSource audioData;
//     public TMP_Text scoreText;
//     private int score;
    
// // Start is called before the first frame update
 void Start()
 {
     audioData = GetComponent<AudioSource>();

//         scoreText.text = "Score : ";
}

    void OnTriggerEnter (Collider collisionInfo){
        if (collisionInfo.tag == "Flame"){
            //soita keräys ääni
            audioData.clip = collectableAudio;
            audioData.Play();
            Debug.Log("collected");

            FlameCollision.scoreValue += 10;
            //coin collection here
            // score = score + 1;
            Destroy(collisionInfo.gameObject);
        }
    }
//     // Update is called once per frame
//     void Update()
//     {
//         scoreText.text = "Score : " + score;
//     }
}
