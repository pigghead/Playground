using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour {
	
	// PRIVATE 
	private GameObject playerCharacter;
	private GameObject tIn;
	private GameObject tOut;

	private Collider playerCollider;
	private Collider inCollider;
	private Collider outCollider;

	private Vector3 offset;

	// MANAGER / HELPER DEPENDENCIES
	public IntersectionManager intersectionMan;

	// Use this for initialization
	void Start () {
		playerCharacter = GameObject.FindGameObjectWithTag ("Player");
		tIn = GameObject.FindGameObjectWithTag ("tIn");
		tOut = GameObject.FindGameObjectWithTag ("tOut");

		playerCollider = playerCharacter.GetComponent<Collider> ();
		inCollider = tIn.GetComponent<Collider> ();
		outCollider = tOut.GetComponent<Collider> ();

		offset = Vector3.up;
	}

	void OnewayTeleport() {
		if (intersectionMan.AABBIntersection(playerCollider, outCollider)) {
			Debug.Log ("We got an intersection!");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
