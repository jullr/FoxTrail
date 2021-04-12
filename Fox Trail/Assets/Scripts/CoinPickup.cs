using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
//     public TMP_Text scoreText;
//     private int score;
    
// // Start is called before the first frame update
//     void Start()
//     {
//         scoreText.text = "Score : ";
//     }

    void OnTriggerEnter (Collider collisionInfo){
        if (collisionInfo.tag == "Player"){
            FlameCollision.scoreValue += 10;
            //coin collection here
            // score = score + 1;
            Destroy(gameObject);
        }
    }
//     // Update is called once per frame
//     void Update()
//     {
//         scoreText.text = "Score : " + score;
//     }
}
