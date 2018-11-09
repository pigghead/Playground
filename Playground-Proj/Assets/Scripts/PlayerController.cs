using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// PRIVATE VARIABLES
	private float moveSpeed;
	private float turnSpeed;
	private float jumpForce;


	// Use this for initialization
	void Start () {
		moveSpeed = 5.0f;
		turnSpeed = 5.0f;
		jumpForce = 8.0f;
	}

	#region PLAYER_MECHANICS
	void MovePlayer() {
		float xMov = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float zMov = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;

		this.transform.Translate (xMov, 0, zMov);
	}

	void JumpPlayer() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, jumpForce, 0), ForceMode.Impulse);
		}
	}

	void RotatePlayer() {
		if (Input.GetMouseButton(1)) {
			float h = Input.GetAxis ("Mouse X") * turnSpeed;

			this.transform.Rotate (0, h, 0);
		}
	}

	void ZoomPlayer() {
		float Zoom = Input.GetAxis ("Mouse ScrollWheel");
		Camera temp = gameObject.transform.GetChild (0).GetComponent<Camera> ();

		if (Zoom > 0.0f) {
			temp.fieldOfView -= 5.0f;
		}

		if (Zoom < 0.0f) {
			temp.fieldOfView += 5.0f;
		}

		if (temp.fieldOfView < 65) {
			temp.fieldOfView = 65;
		}

		if (temp.fieldOfView > 95) {
			temp.fieldOfView = 95;
		}

		//Mathf.Clamp (temp.fieldOfView, 60.0f, 95.0f);
	}
	#endregion
	
	// Update is called once per frame
	void Update () {
		MovePlayer ();
		JumpPlayer ();
		RotatePlayer ();
		ZoomPlayer ();
	}
}
