using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour {
	
	public float gravity = -9.8f;
	

	//for improved jump
	//travel = positive when moving up and negative when falling down
	public float travel; 
	public float previousDistance;
	public float currentDistance;

	// for improved jump
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;
		
	public void Attract(Rigidbody body) {
		//gravityUp = Player's distance from Sphere planet (player position - sphere position). 
		//localUp = player's local up direction
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.transform.up;
		

		//..........For improved jump.........................
		//distance between player and sphere
		currentDistance = Vector3.Distance (body.position, transform.position);

		// travel tells if height has increased or decreased
		travel = currentDistance - previousDistance;
		previousDistance = currentDistance;

		//..........Improved jump adjusted for Sphere gravity..........................................................
		if (travel < 0){
			body.velocity += localUp * gravity * (fallMultiplier - 1) * Time.deltaTime;
		}else if ( travel > 0 && !Input.GetButton("Jump")){
			body.velocity += localUp * gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
		//..............improved jump end................................


		// Apply downwards gravity to body
		body.AddForce(gravityUp * gravity);
		// Allign bodies up axis with the centre of planet
		body.rotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
	}  
}