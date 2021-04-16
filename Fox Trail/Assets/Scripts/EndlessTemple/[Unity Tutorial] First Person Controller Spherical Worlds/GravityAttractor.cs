using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour {
	
	public float gravity = -9.8f;
	

	//for better jump
	//travel = positiivinen ylöpäin liikkuessa ja negatiivinen alaspäin pudotessa
	public float travel; 
	public float previousDistance;
	public float currentDistance;

	// for better jump
	public float fallMultiplier = 2.5f;
	public float lowJumpMultiplier = 2f;
		
	public void Attract(Rigidbody body) {
		//gravityUp = Pelaajan etäisyys Spherestä (pelaaja positio - sphere position). 
		//localUp = pelaajan local ylös päin suunta
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.transform.up;
		

		//..........For better jump.........................
		//kertoo etäisyyden pelaajan ja orbin välillä
		currentDistance = Vector3.Distance (body.position, transform.position);

		// travel kertoo onko korkeus pienentynyt vai suurentunut
		travel = currentDistance - previousDistance;
		previousDistance = currentDistance;

		//..........Better jump adjusted for Sphere gravity..........................................................
		if (travel < 0){
			body.velocity += localUp * gravity * (fallMultiplier - 1) * Time.deltaTime;
		}else if ( travel > 0 && !Input.GetButton("Jump")){
			body.velocity += localUp * gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
		//..............better jump end................................


		// Apply downwards gravity to body
		body.AddForce(gravityUp * gravity);
		// Allign bodies up axis with the centre of planet
		body.rotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
	}  
}