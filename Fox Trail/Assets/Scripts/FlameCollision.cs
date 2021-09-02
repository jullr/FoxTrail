using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlameCollision : MonoBehaviour
{

    //score value is added to score text.
    public TMP_Text scoreText;
    public static int scoreValue = 0;
    
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        scoreText.text = "Score: " + scoreValue;
    }
}
