using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlameCollision : MonoBehaviour
{

    //tässä tekstiin lisätään score määrä. flame objektille ei tehdä mitään.
    public TMP_Text scoreText;
    public static int scoreValue = 0;
    
// Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        //scoreText.text = "Score: " + scoreValue;
    }

    // void OnTriggerEnter (Collider collisionInfo){
    //     if (collisionInfo.tag == "Player"){
    //         //coin collection here
    //         scoreValue = scoreValue + 1;
    //         Destroy(gameObject);
    //     }
    // }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreValue;
    }
}
