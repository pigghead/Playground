using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

	// PRIVATE
	private float moveSpeed;	// Speed in which PC moves
	private float jumpForce;	// force in which PC jumps

	public Vector3 header;
	private Vector3 velocity;
	private Vector3 lastPosition;

	// Use this for initialization
	void Start () {
		moveSpeed = 5.0f;
		jumpForce = 5.0f;
	}

	void PlayerActions() {
		// Moving
		float h = Input.GetAxisRaw("Horizontal");
		Vector3 tV3 = new Vector3 (h, 0, 0);
		tV3 = tV3.normalized * moveSpeed * Time.deltaTime;

		if (Input.GetKey(KeyCode.D)) {
			this.gameObject.GetComponent<Rigidbody> ().MovePosition (this.gameObject.transform.position + tV3);
		}

		if (Input.GetKey(KeyCode.A)) {
			tV3 = -tV3;
			this.gameObject.GetComponent<Rigidbody> ().MovePosition (this.gameObject.transform.position - tV3);
		}

		// Jumping
		if (Input.GetKeyDown(KeyCode.Space)) {
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3(0, jumpForce, 0), ForceMode.Impulse);
			Debug.Log ("Jump: " + jumpForce);
		}
	}

	void CollisionDetection() {

	}

	// Update is called once per frame
	void Update () {
		PlayerActions ();

		velocity = (transform.position - lastPosition) / Time.deltaTime;
		lastPosition = transform.position;

		header = velocity;
	}
}
