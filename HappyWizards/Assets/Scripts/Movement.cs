using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {
		var y = Input.GetAxis("Vertical") *speed*Time.deltaTime;
		var x = Input.GetAxis("Horizontal") *speed*Time.deltaTime;

		transform.Translate(x,y,0);

	}
}
