using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    //käytetään mittaamaan ruudun koko, objektien tuhoamista varten
    private Vector3 screenBounds;

    //platform aluetta  spawnaukseen
    public Transform tile1Obj;
    private Vector3 nextTileSpawn;

    //brick niminen este spawnaukseen
    public Transform bricksObj;
    private Vector3 nextBrickSpawn;

    private int randX;
    private int randChoice; 

    //smCrate niminen este spawnaukseen
    public Transform smCrateObj;
    private Vector3 nextsmCrateSpawn;

    //dbCrate niminen este spawnaukseen
    public Transform dbCrateObj;
    private Vector3 nextDbCrateSpawn; 

    //cartObj niminen este spawnaukseen
    public Transform cartObj;
    private Vector3 nextCartSpawn;

    void Start()
    {
        //spawnaa kohtaan z21 platformin, aloittaa IEnumerator toiminnan
        nextTileSpawn.z = 18;
        StartCoroutine(spawnTile());  

        //ruudun mittaaminen
        screenBounds = Camera.main.ScreenToWorldPoint (new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));  
    }

    void Update()
    {
        
    }
    //spawnaa sekunnin välein jatkuvasti lisää platformia z3 yksikön päähän edellisestä = endless runner
    //spawnaa esteitä randomisti kohtiin -1, 0 tai 1 (brickObj ja smCrateObj)
    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        randX = Random.Range(-1,2);
        nextBrickSpawn = nextTileSpawn;
        nextBrickSpawn.y = .2f;
        nextBrickSpawn.x = randX; 
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(bricksObj, nextBrickSpawn, bricksObj.rotation);
        

        nextTileSpawn.z += 3;
        randX = Random.Range(-1,2);
        nextsmCrateSpawn.z = nextTileSpawn.z;
        nextsmCrateSpawn.y = .2f;
        nextsmCrateSpawn.x = randX;
        Instantiate(tile1Obj, nextTileSpawn, tile1Obj.rotation);
        Instantiate(smCrateObj, nextsmCrateSpawn, smCrateObj.rotation);

        //randX will be different than earlier. 
        if (randX == 0){
            randX = 1;
        }else if (randX == 1){
             randX = -1;
        }else{
            randX = 0;
        }

        randChoice = Random.Range(0,2);
        if (randChoice == 0){
            nextDbCrateSpawn.z = nextTileSpawn.z;
            nextDbCrateSpawn.y = .2f;
            nextDbCrateSpawn.x = randX;
            Instantiate(dbCrateObj, nextDbCrateSpawn, dbCrateObj.rotation);
        }else{
            nextCartSpawn.z = nextTileSpawn.z;
            nextCartSpawn.y = .2f;
            nextCartSpawn.x = randX;
            Instantiate(cartObj, nextCartSpawn, cartObj.rotation); 
  
        }


        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
        
       
        
    }
}
