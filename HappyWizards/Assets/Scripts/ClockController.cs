using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class ClockController : MonoBehaviour {

	DateTime time;
	public Text timeText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time = System.DateTime.Now;
		timeText.text = time.Hour + ":" + time.Minute;
	}

	public DateTime GetDate(){
		return time;
	}
	public TimeSpan GetTime(){
		return time.TimeOfDay;
	}
}
