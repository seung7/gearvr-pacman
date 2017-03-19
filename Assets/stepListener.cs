using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stepListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public float speed = 10.0F;
	// Update is called once per frame
	void Update () {
		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.y = Input.acceleration.y;
		dir.z = Input.acceleration.z;

		transform.Translate (transform.forward * 1.0f * Time.deltaTime); 
	
		if (dir.sqrMagnitude < 0.3) {
			transform.Translate (transform.forward * 100);
		}
			

	}
}
