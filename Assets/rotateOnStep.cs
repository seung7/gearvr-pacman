using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateOnStep : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.y = Input.acceleration.y;
		dir.z = Input.acceleration.z;
		//transform.Rotate (0.0f, 45.0f, 0.0f);
		if (dir.sqrMagnitude < 0.3) {
			transform.Rotate (0.0f, 45.0f, 0.0f);
		}
	}
}
