using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour {
	// PRIVATE
	[SerializeField] private bool debugEnabled;
	private GameObject playerCharacter;

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
			//Gizmos.DrawWireCube (playerCharacter.transform.position, new Vector3(0.7f, 0.7f, 0.7f));
			Gizmos.DrawWireMesh(
				playerCharacter.GetComponent<MeshFilter>().mesh, 
				playerCharacter.transform.position, 
				Quaternion.identity, 
				Vector3.one
			);
		}
	}

	// Update is called once per frame
	void Update () {
		DetectInput ();
	}
}
