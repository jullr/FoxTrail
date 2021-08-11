using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
   

void Update() {
    if(Input.GetButtonDown("Jump")) {
            Quit();
    } 
}

void Quit()
{
        Application.Quit();
        Debug.Log("Game is exiting");
}
        

}
