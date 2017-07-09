using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour {

	public Transform transform;
	public Vector3 v2;
	public bool yes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(yes){
		RaycastHit2D hit = Physics2D.Raycast(transform.position, v2);
		if(hit){
		Debug.Log(hit.transform.parent.parent.name);
	}}}
}
