using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionManager : MonoBehaviour {

	// BOX TO BOX COLLISION DETECTION HELPER METHOD
	public bool AABBIntersection(Collider A, Collider B) {
		return (A.bounds.min.x <= B.bounds.max.x && A.bounds.max.x >= B.bounds.min.x) &&
		(A.bounds.min.y <= B.bounds.max.y && A.bounds.max.y >= B.bounds.min.y) &&
		(A.bounds.min.z <= B.bounds.max.z && A.bounds.max.z >= B.bounds.min.z);
	}
}
