using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOnStep : MonoBehaviour {
	private Transform camera;
	private int count = 0;
	// Use this for initialization
	void Start () {
		camera = this.gameObject.transform.GetChild (0);

	}
	
	// Update is called once per frame
	void Update () {		
		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.y = Input.acceleration.y;
		dir.z = Input.acceleration.z;
		//transform.Translate (camera.forward * 0.05f * Time.deltaTime);
		if (count == 0) {
			Handheld.Vibrate ();
			count++;
		}

		if (dir.sqrMagnitude < 0.4) {
			transform.Translate (camera.forward * 10.0f * Time.deltaTime); 
		}
	}
}
