using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

	// PRIVATE
	private float moveSpeed;	// Speed in which PC moves
	private float jumpForce;	// force in which PC jumps

	// Use this for initialization
	void Start () {
		moveSpeed = 5.0f;
		jumpForce = 3.0f;
	}

	void PlayerActions() {
		// Moving
		float xMov = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

		this.transform.Translate (xMov, 0, 0);

		// Jumping
		if (Input.GetKeyDown(KeyCode.Space)) {
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3(0, jumpForce, 0), ForceMode.Impulse);
			Debug.Log ("Jump: " + jumpForce);
		}
	}

	// Update is called once per frame
	void Update () {
		PlayerActions ();
	}
}
