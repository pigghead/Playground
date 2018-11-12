using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

	// PUBLIC
	//public List<GameObject> movingPlatforms;
	public GameObject movingPlatform;

	// PRIVATE
	private float moveSpeed;

	// Use this for initialization
	void Start () {
		//movingPlatforms = new List<GameObject>();
		moveSpeed = 0.1f;
	}

	void Move() {
		Vector3 h = Vector3.right * moveSpeed * Time.deltaTime;

		movingPlatform.transform.Translate (h);
		//movingPlatforms [0].transform.Translate (h);
	}

	// Update is called once per frame
	void FixedUpdate () {
		Move ();
	}
}
