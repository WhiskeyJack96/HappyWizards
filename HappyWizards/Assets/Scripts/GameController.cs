using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController controller;

	//Put persistent data here


	void Awake () {
		if(controller == null){
			DontDestroyOnLoad(gameObject);
			controller = this;
		}
		else if(controller != this){
			Destroy(gameObject);
		}
	}
	

}
