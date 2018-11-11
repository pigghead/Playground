using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour {
	// PRIVATE
	[SerializeField] private bool debugEnabled;
	private GameObject playerCharacter;
	//private Ray r;

	// Use this for initialization
	void Start () {
		debugEnabled = false;
		playerCharacter = GameObject.FindGameObjectWithTag ("Player");
	}

	// Detect deBug being enabled / disabled
	void DetectInput() {
		if (Input.GetKeyDown(KeyCode.B)) {
			debugEnabled = !debugEnabled;
		}
	}

	void OnDrawGizmos() {
		if (debugEnabled == true) {
			Gizmos.color = Color.green;
			Gizmos.DrawWireMesh(
				playerCharacter.GetComponent<MeshFilter>().mesh, 
				playerCharacter.transform.position, 
				Quaternion.identity, 
				Vector3.one
			);

			Gizmos.color = Color.blue;
			Gizmos.DrawLine (playerCharacter.transform.position, playerCharacter.transform.position + playerCharacter.GetComponent<PlatformController>().header);
		}
	}

	// Update is called once per frame
	void Update () {
		DetectInput ();
	}
}
