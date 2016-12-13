using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	Rigidbody2D rb ;

	public float speed;

	void Start(){
		rb = GetComponent<Rigidbody2D>();
	}
	// Update is called once per frame
	void FixedUpdate () {
		var y = Input.GetAxis("Vertical") *speed;//*Time.deltaTime;
		var x = Input.GetAxis("Horizontal") *speed;//*Time.deltaTime;

		rb.velocity = new Vector3(x,y,0);

//		transform.Translate(x,y,0);

	}

	void OnCollisionEnter(Collision other) {
		GetComponent<Rigidbody2D>().velocity = Vector3.zero;
	}
}
