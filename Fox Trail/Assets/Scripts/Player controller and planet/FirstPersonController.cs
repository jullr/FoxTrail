using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GravityBody))]
public class FirstPersonController : MonoBehaviour {
	
	// public vars
	public float walkSpeed = 6;
	public float jumpForce = 220;
	public LayerMask groundedMask;

	//For audio
	public AudioSource runAudioSource;
	public AudioSource jumpAudioSource;

	// System vars
	bool grounded;
	Vector3 moveAmount;
	Vector3 smoothMoveVelocity;
	Rigidbody rb;

	//For animations
	private Animator animator;
	
	
	void Awake() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		rb = GetComponent<Rigidbody> ();
		animator = GetComponent<Animator>();
	}

	void Update() {
		
		// Calculate movement:
		float inputX = Input.GetAxisRaw("Horizontal");
		
		Vector3 moveDir = new Vector3(inputX, 0, 0).normalized;
		Vector3 targetMoveAmount = moveDir * walkSpeed;
		moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount,ref smoothMoveVelocity,.15f);
		
		//...............................................................................
		// Basic Jump
		if (Input.GetButtonDown("Jump")) {
			if (grounded) {
				rb.AddForce(transform.up * jumpForce);
				animator.Play("FoxJump");
				jumpAudioSource.Play();
			}
		}
		//.......................................................................................
		// Grounded check
		Ray ray = new Ray(transform.position, -transform.up);
		RaycastHit hit;
		
		if (Physics.Raycast(ray, out hit, 1 + .1f, groundedMask)) {
			grounded = true;
            if (!runAudioSource.isPlaying)
            {
				runAudioSource.Play();
			}
		}else {
			grounded = false;
			runAudioSource.Stop();
		}
		
	}
	
	void FixedUpdate() {
		// Apply movement to rigidbody
		Vector3 localMove = transform.TransformDirection(moveAmount) * Time.fixedDeltaTime;
		rb.MovePosition(rb.position + localMove);
	}
}