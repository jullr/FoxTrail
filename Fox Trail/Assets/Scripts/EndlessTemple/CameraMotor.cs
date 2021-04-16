using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    //kamera seuraa pelaajaa, aloitus animaatio alussa, offset käytössä.
    // Käytetty ainakin "Pelaaja" playerilla. 


    // //kamera seuraa pelaajaa
    // private Transform lookAt;
    // //ottaa offset määrän kameran alku sijainnista verrattuna pelaajan sijaintiin
    // private Vector3 startOffset; 
    // //updatessa kameran positio on pelaajan positio + offset
    // private Vector3 moveVector;

    // //transition käytetään ajan laskemiseen, alkuanimaatiota varten. 
    // private float transition = 0.0f;
    // private float animationDuration = 2.0f; 
    // //animaatiossa tulee offsettia 0,5,5
    // private Vector3 animationOffset = new Vector3(0,5,5); 

    // // Start is called before the first frame update
    // void Start()
    // {
    //     //etsii pelaajan tag nimen perusteella, määrittää alku offsetin. 
    //     lookAt = GameObject.FindGameObjectWithTag("Player").transform;
    //     startOffset = transform.position - lookAt.position;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     //määrittää kameran sijainnin
    //     moveVector = lookAt.position + startOffset;

    //     //X, ei liiku sivusuunnassa:
    //     //moveVector.x = 0;

    //     //Y, ylös alas liike rajoitettu välille 3 ja 5.
    //     //moveVector.y = Mathf.Clamp(moveVector.y,3,5);

    //     //kun ollaan liikuttu eteenpäin 1 alkaa normi liikkuminen, sitä ennen on animaatio (else)  
    //     if(transition > 1.0f){
    //     transform.position = moveVector; 
    //     }else{
    //         //Animation at the start of the game
    //         transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
    //         transition += Time.deltaTime * 1 / animationDuration;
    //         transform.LookAt(lookAt.position + Vector3.up);
    //     }

    // }

    //---------------------------------------------------------------

    //Make A 3D Platformer in Unity #4: Moving the Camera & Smooth Jumps tutorialista.


    public  Transform target;

    public Vector3 offset; 

    //checkbox for Inspector: use offset values or not (camera placement is the other option)
    public bool useOffsetValues; 

    void Start() {

        //checks if checkbox is ticked
        if (!useOffsetValues){
        offset = target.position - transform.position; 
        }
        
    }

    void Update() {
        
        transform.position = target.position - offset;
        //camera kääntyy katsomaan targettia mihin suuntaan vain (rotation). Ei liiku (position).
        transform.LookAt(target);


    }







}
