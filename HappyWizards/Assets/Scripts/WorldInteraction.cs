using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldInteraction : MonoBehaviour {

	public KeyCode interact;
	public GameObject Other;
	public GameObject Holding;
	public StorageContainer container;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(interact)){
			Interact();
		}
		if(Holding != null){
			Holding.transform.position = this.transform.position;
		}
	}

	void Interact() {
		Debug.Log(Other);
		if (Holding != null){
			Holding.transform.position = this.transform.position + new Vector3(1,0,0);
			Holding.GetComponent<Collider2D>().enabled = true;
			Holding = null;
		}
		else{
			Holding = Other;
			Holding.GetComponent<Collider2D>().enabled=false;
			Holding.transform.position = this.transform.position;
		}
	}

	/*void Inventory(){
		GameObject obj = container.storage[0];
		container.RemoveItem(obj);
		Debug.Log(obj.name);
		GameObject temp = (GameObject)Resources.Load(obj.name);
		//obj.transform.position = new Vector3(0,0,0);
		Instantiate(temp, new Vector3(0,0,0), Quaternion.identity);
	}*/

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "PickUp"){
			Other = other.gameObject;
		}
	
		else if(other.gameObject.tag == "Storable"){
			container.AddItem(other.gameObject.name);
		}
	}
}
